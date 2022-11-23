using Gateway;

var hostBuilder = Host.CreateDefaultBuilder()
    .ConfigureSilkyGatewayDefaults(webHostBuilder => webHostBuilder.UseStartup<Startup>());
await hostBuilder.Build().RunAsync();