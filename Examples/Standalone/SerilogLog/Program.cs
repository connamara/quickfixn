using Serilog;
using Serilog.Core;
using Serilog.Filters;
using Serilog.Formatting.Json;

namespace SerilogLog;

class Program
{
    static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.Logger(l => l
                .Filter
                .ByIncludingOnly(Matching.FromSource("QuickFix.SessionLogs"))
                .Filter
                .ByIncludingOnly(Matching.WithProperty("MessageType"))
                .WriteTo.Map(Constants.SourceContextPropertyName, "", (source, lc) =>
                {
                    var fileName = GetSessionIdFromSourceContext(source);
                    lc.File($"log/{fileName}.messages.log", rollingInterval: RollingInterval.Hour, outputTemplate:"{Message:lj}{NewLine}");
                })
            )
            .WriteTo.Logger(l => l
                .Filter
                .ByIncludingOnly(Matching.FromSource("QuickFix.SessionLogs"))
                .Filter
                .ByExcluding(Matching.WithProperty("MessageType"))
                .WriteTo.Map(Constants.SourceContextPropertyName, "", (source, lc) =>
                {
                    var fileName = GetSessionIdFromSourceContext(source);
                    lc.File($"log/{fileName}.event.log", rollingInterval: RollingInterval.Minute, outputTemplate:"{Message:lj}{NewLine}");
                })
            )
            .WriteTo.Logger(l => l
                .Filter
                .ByIncludingOnly(Matching.FromSource("QuickFix"))
                .Filter
                .ByExcluding(Matching.FromSource("QuickFix.SessionLogs"))
                .WriteTo.File("log/Non-Session-Log.event.current.log")
            )
            .CreateLogger();

        try
        {
            Log.Information("Starting host");

            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddHostedService<FixBackgroundService>();
            builder.Services.AddSerilog();
            builder.Services.Configure<AppSettings>(builder.Configuration);
            var app = builder.Build();

            await app.RunAsync();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Host terminated unexpectedly");
        }
        finally
        {
            await Log.CloseAndFlushAsync();
        }
    }

    private static string GetSessionIdFromSourceContext(string sourceContext)
    {
        // Log source is "QuickFix.SessionLogs.<session-id>", this returns <session-id>
        var i = sourceContext.IndexOf('.', sourceContext.IndexOf('.') + 1) + 1;
        return sourceContext[i..];
    }
}
