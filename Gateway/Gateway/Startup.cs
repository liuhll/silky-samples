namespace Gateway;

public class Startup
{
    public void ConfigureService(IServiceCollection services)
    {
        services.AddSilkyHttpServices()
            .AddRouting()
            .AddSwaggerDocuments()
            .AddMiniProfiler();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwaggerDocuments();
            app.UseMiniProfiler();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints => { endpoints.MapSilkyRpcServices(); });
    }
}