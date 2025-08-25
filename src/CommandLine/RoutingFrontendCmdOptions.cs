using CommandLine;
using Gay.Silverbranch.Api.Utilities.Common.CommandLine;
using Gay.Silverbranch.Api.Utilities.Common.CommandLine.Interface;

namespace Gay.Silverbranch.Api.Utilities.Client.CommandLine;

public class RoutingFrontendCmdOptions : RoutingCmdOptions, IHealthCheckCmdOptions
{
    [Option("ready", Default = 5051)]
    public int ReadyCheckPort { get; set; }

    [Option("liveness", Default = 5052)]
    public int LivenessCheckPort { get; set; }

    [Option("startup", Default = 5050)]
    public int StartupCheckPort { get; set; }

    [Option('h', "health-host", Required = true)]
    public string HealthChecksHostAddress { get; set; } = "*";
    
    //[Option("startuptime", Default = 10)]
    //public int FakedStartupDurationInSeconds { get; set; }
}