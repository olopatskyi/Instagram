namespace Instagram.Identity.API;

public class Programm
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath);
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                config.AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json",
                    optional: true, reloadOnChange: true);

                config.AddEnvironmentVariables();
            })
            .ConfigureWebHostDefaults(configurations =>
            {
                configurations.UseStartup<Startup>();
            });
}