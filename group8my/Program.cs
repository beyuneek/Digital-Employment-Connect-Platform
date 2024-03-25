namespace group8my
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //https://localhost:44386/api/JobOffers
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            /*.ConfigureAppConfiguration((context, builder) =>
            {
                builder.AddSystemsManager("/ManyJobsAPI");
            })*/
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
