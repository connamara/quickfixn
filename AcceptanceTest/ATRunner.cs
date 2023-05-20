#nullable enable
using AcceptanceTest.Xml;
using QuickFix;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AcceptanceTest
{
    public class ATRunner
    {
        private static async Task Main(string[] args)
        {
            SetCurrentDirectory();

            if (args.Length != 3 || !bool.TryParse(args[2], out bool useWsl))
            {
                Console.WriteLine("usage:   AcceptanceTest.exe <test_definitions> <config_filepath> <use_wsl>(true|false)");
                Console.WriteLine("example: AcceptanceTest.exe \"definitions/server/fix40/*.def\" \"cfg/at_40.cfg\" true\"");
                Console.WriteLine($"The paths should be relative to the AcceptanceTest directory ({Directory.GetCurrentDirectory()}), or absolute.");
                Environment.Exit(2);
                return;
            }

            string testDefinitions = args[0];
            string configFilePath = args[1];

            SessionSettings settings = new(configFilePath);

            int port = settings.Get().GetInt(SessionSettings.SOCKET_ACCEPT_PORT);

            using (CancellationTokenSource cts = new())
            {
                // Start the acceptor
                Task acceptorTask = RunAcceptor(settings, cts.Token);
                Task<int> rubyRunnerTask = RunRubyRunner(useWsl, port, testDefinitions, cts.Token);

                Task firstCompletedTask = await Task.WhenAny(acceptorTask, rubyRunnerTask);

                if (firstCompletedTask == acceptorTask)
                {
                    // The acceptor probably threw an exception e.g ConfigError.
                    // Bubble it up here
                    try
                    {
                        await acceptorTask;
                    }
                    finally
                    {
                        // Cancel the ruby process
                        cts.Cancel();
                    }
                }

                // Run the ruby tests and propagate the exit code.
                // The output will be written to TestResult.xml
                Environment.ExitCode = await rubyRunnerTask;

                try
                {
                    // Stop the acceptor
                    cts.Cancel();
                    await acceptorTask;
                }
                catch (OperationCanceledException oce) when (oce.CancellationToken == cts.Token)
                { }
            }

            // Read TestResult.xml and print the summary to the console
            PrintResults(testDefinitions, printTable: false);
        }

        private static async Task RunAcceptor(SessionSettings settings, CancellationToken cancellationToken)
        {
            using SemaphoreSlim stopMe = new(initialCount: 0, maxCount: 1);
            using FileLog debugLog = new FileLog("log", new SessionID("AT", "Application", "Debug"));

            ATApplication testApp = new ATApplication(debugLog);
            testApp.StopMeEvent += () => stopMe.Release();

            IMessageStoreFactory storeFactory = new FileStoreFactory(settings);

            ILogFactory? logFactory = settings.Get().Has("Verbose") && settings.Get().GetBool("Verbose")
                ? new FileLogFactory(settings)
                : null;

            using ThreadedSocketAcceptor acceptor = new(testApp, storeFactory, settings, logFactory);

            acceptor.Start();

            while (true)
            {
                // for tests of logout
                await stopMe.WaitAsync(cancellationToken);
                // this doesn't seem to work
                // after stop, it doesn't seem to start up again
                /*
                acceptor.Stop();
                await Task.Delay(5 * 1000, cancellationToken);
                acceptor.Start();
                    */
            }
        }

        private static async Task<int> RunRubyRunner(bool useWsl, int port, string testDefinitions, CancellationToken cancellationToken)
        {
            ProcessStartInfo processStartInfo;

            if (useWsl)
            {
                processStartInfo = new("wsl");
                processStartInfo.ArgumentList.Add("ruby");
            }
            else
            {
                processStartInfo = new("ruby");
            }

            processStartInfo.ArgumentList.Add("Runner.rb");
            processStartInfo.ArgumentList.Add("127.0.0.1");
            processStartInfo.ArgumentList.Add(port.ToString());
            processStartInfo.ArgumentList.Add(testDefinitions);

            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;

            Process process = Process.Start(processStartInfo)!;

            using CancellationTokenRegistration reg = cancellationToken.Register(() => process.Kill(entireProcessTree: true));

            async Task ReadStandardOutput()
            {
                using FileStream fs = File.Create("TestResult.xml");
                using StreamWriter sw = new(fs);

                string? line;
                while ((line = await process.StandardOutput.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                    sw.WriteLine(line);
                }
            }

            async Task ReadStandardError()
            {
                string? line;
                while ((line = await process.StandardError.ReadLineAsync()) != null)
                {
                    Console.Error.WriteLine(line);
                }
            }

            await Task.WhenAll(process.WaitForExitAsync(cancellationToken), ReadStandardOutput(), ReadStandardError());

            return process.ExitCode;
        }

        private static void PrintResults(string testDefinitions, bool printTable)
        {
            Xml.AcceptanceTest at;
            XmlSerializer xmlSerializer = new(typeof(Xml.AcceptanceTest));
            using (FileStream fs = File.OpenRead("TestResult.xml"))
            {
                at = (Xml.AcceptanceTest)xmlSerializer.Deserialize(fs)!;
            }

            if (printTable)
            {
                int maxWidth = at.Tests.Max(t => Path.GetFileName(t.Name).Length);

                Console.WriteLine($"{"Name".PadRight(maxWidth)} Result  Message");
                Console.WriteLine($"{"----".PadRight(maxWidth)} ------  -------");

                foreach (Test t in at.Tests)
                {
                    Console.WriteLine($"{Path.GetFileName(t.Name).PadRight(maxWidth)} {t.Result} {t.Message?.Text.Trim()}");
                }
            }

            string? version = Path.GetFileName(Path.GetDirectoryName(testDefinitions));

            if (version is not null &&
                Regex.Match(version, @"(?in)^fix(?<Major>\d)(?<Minor>\d)(?<ServicePack>(?<Prefix>SP)(?<Number>\d+))?$") is Match { Success: true } m)
            {
                // Format the version e.g. "fix50sp2" => "FIX 5.0 SP 2"
                version = $"FIX {m.Groups["Major"]}.{m.Groups["Minor"]} {m.Groups["Prefix"]} {m.Groups["Number"]}".TrimEnd().ToUpperInvariant();
            }

            version += $" (net{Environment.Version.Major}.{Environment.Version.Minor})";

            Console.WriteLine();
            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"{version} Results:");
            Console.WriteLine($"  Total Tests: {at.Results.Total,3}");
            Console.WriteLine($"      Passing: {at.Results.Total - at.Results.Failures,3}");
            Console.WriteLine($"      Failing: {at.Results.Failures,3}");
            Console.WriteLine();
        }

        /// <summary>
        /// Sets the current directory to the AcceptanceTest directory at the root of the repo.
        /// This makes the relative paths defined in the cfg and args work correctly whether this
        /// application is running via <c>dotnet run</c> or via Visual Studio.
        /// </summary>
        /// <remarks>
        /// This assumes the current directory (given by <see cref="Directory.GetCurrentDirectory"/>)
        /// is either the AcceptanceTest directory or somewhere below it, such as
        /// AcceptanceTest/bin/Debug/net6.0/. This method will walk up the current path until it finds the
        /// AcceptanceTest directory, and then call <see cref="Directory.SetCurrentDirectory(string)"/>.
        /// </remarks>
        /// <exception cref="DirectoryNotFoundException">
        /// The method could not find the AcceptanceTest directory im the current directory path.
        /// </exception>
        private static void SetCurrentDirectory()
        {
            string? acceptanceTestDirPath = Directory.GetCurrentDirectory();

            while (true)
            {
                string? dirName = Path.GetFileName(acceptanceTestDirPath);

                if (string.IsNullOrEmpty(dirName))
                {
                    throw new DirectoryNotFoundException($"Could not find AcceptanceTest directory in {Directory.GetCurrentDirectory()}");
                }

                if (dirName == "AcceptanceTest")
                {
                    Directory.SetCurrentDirectory(acceptanceTestDirPath!);
                    break;
                }

                acceptanceTestDirPath = Path.GetDirectoryName(acceptanceTestDirPath);
            }
        }
    }
}
