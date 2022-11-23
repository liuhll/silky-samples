using Microsoft.Extensions.Hosting;

var hostBuilder = Host.CreateDefaultBuilder().ConfigureSilkyGeneralHostDefaults();
await hostBuilder.Build().RunAsync();