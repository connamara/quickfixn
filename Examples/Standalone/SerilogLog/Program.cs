﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;
using Serilog.Filters;

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
                .ByIncludingOnly("EventId.Id in [7702, 7703]") // QuickFix.Logger.LogEventIds.IncomingMessage.Id
                                                               //    and .OutgoingMessage.Id
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
                .ByExcluding("EventId.Id in [7702, 7703]")
                .WriteTo.Map(Constants.SourceContextPropertyName, "", (source, lc) =>
                {
                    var fileName = GetSessionIdFromSourceContext(source);
                    lc.File($"log/{fileName}.event.log", rollingInterval: RollingInterval.Hour, outputTemplate:"{Message:lj}{NewLine}");
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
