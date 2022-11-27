using Com.Ctrip.Framework.Apollo.ConfigAdapter;
using Com.Ctrip.Framework.Apollo.Logging;
using Microsoft.Extensions.Hosting;

// LogManager.UseConsoleLogging(LogLevel.Trace);
YamlConfigAdapter.Register();
var hostBuilder = Host.CreateDefaultBuilder().ConfigureSilkyGeneralHostDefaults().AddApollo();
await hostBuilder.Build().RunAsync();