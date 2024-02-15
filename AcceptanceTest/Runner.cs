using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace AcceptanceTest;

internal class Runner : IDisposable
{
    private readonly IPEndPoint _endPoint;
    private readonly Dictionary<int, IReflector> _connections;

    public Runner(IPEndPoint endPoint)
    {
        _endPoint = endPoint;
        _connections = new Dictionary<int, IReflector>();
    }

    public void Run(TextReader testCase)
    {
        string? line;

        while ((line = testCase.ReadLine()) != null)
        {
            line = line.Trim();

            if (line.Length == 0 || line[0] == '#')
            {
                continue;
            }

            if (line.StartsWith("sleep(") && line[^1] == ')')
            {
                // e.g. sleep(0.5)

                Thread.Sleep(TimeSpan.FromSeconds(double.Parse(line[6..^1])));
            }
            else if (line[0] is 'i' or 'e' && line.EndsWith("DISCONNECT"))
            {
                // e.g. iDISCONNECT; i1,DISCONNECT; eDISCONNECT; e1,DISCONNECT

                int connectionId = line[^11] == ',' ? int.Parse(line[1..^11]) : 1;

                if (line[0] == 'i')
                {
                    _connections[connectionId].InitiateDisconnect();
                }
                else
                {
                    _connections[connectionId].ExpectDisconnect();
                }
            }
            else if (line[0] == 'i' && line.EndsWith("CONNECT"))
            {
                // e.g. iCONNECT; i1,CONNECT

                int connectionId = line[^8] == ',' ? int.Parse(line[1..^8]) : 1;

                if (!_connections.TryGetValue(connectionId, out IReflector? reflector))
                {
                    _connections.Add(connectionId, reflector = new ReflectorClient(_endPoint));
                }

                reflector.InitiateConnect();
            }
            else if (line[0] is 'I' or 'E')
            {
                // e.g. I8=FIXT.1.1|...; I1,8=FIXT.1.1|...; E8=FIXT.1.1|...; E1,8=FIXT.1.1|...

                int messageStartIndex = 1;
                while (char.IsDigit(line[messageStartIndex])) messageStartIndex++;

                int connectionId;

                if (line[messageStartIndex] == ',')
                {
                    connectionId = int.Parse(line.Substring(1, messageStartIndex - 1));
                    messageStartIndex++;
                }
                else
                {
                    connectionId = 1;
                    messageStartIndex = 1;
                }

                string message = System.Text.Encoding.GetEncoding("iso-8859-1").GetString(
                                   System.Text.Encoding.UTF8.GetBytes(
                                       line.Substring(messageStartIndex)));

                if (line[0] == 'I')
                {
                    _connections[connectionId].Initiate(message);
                }
                else
                {
                    _connections[connectionId].Expect(message);
                }
            }
            else
            {
                Assert.Fail($"Invalid line \"{line}\"");
            }
        }
    }

    public void Dispose()
    {
        foreach (IReflector reflector in _connections.Values)
        {
            reflector.Dispose();
        }
    }
}
