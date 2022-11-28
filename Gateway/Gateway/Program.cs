using Gateway;

// YamlConfigAdapter.Register();
var hostBuilder = Host.CreateDefaultBuilder()
        .ConfigureSilkyGatewayDefaults(webHostBuilder => webHostBuilder.UseStartup<Startup>())
        .UseNacosConfig("NacosConfig", Nacos.YamlParser.YamlConfigurationStringParser.Instance)
    // .AddApollo()
    ;
await hostBuilder.Build().RunAsync();