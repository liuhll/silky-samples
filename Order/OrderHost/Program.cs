using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

// LogManager.UseConsoleLogging(LogLevel.Trace);
// YamlConfigAdapter.Register();
var hostBuilder = Host.CreateDefaultBuilder()
        .ConfigureSilkyGeneralHostDefaults()
        .UseNacosConfig("nacosConfig", Nacos.YamlParser.YamlConfigurationStringParser.Instance)
    //.AddApollo()
    ;
await hostBuilder.Build().RunAsync();