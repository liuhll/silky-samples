using Com.Ctrip.Framework.Apollo.ConfigAdapter;
using Gateway;

YamlConfigAdapter.Register();
var hostBuilder = Host.CreateDefaultBuilder()
    .ConfigureSilkyGatewayDefaults(webHostBuilder => webHostBuilder.UseStartup<Startup>())
    .AddApollo();
await hostBuilder.Build().RunAsync();