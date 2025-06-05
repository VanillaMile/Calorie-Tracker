using Calorie_Tracker.data;
using Microsoft.Extensions.Configuration;

namespace Calorie_Tracker
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Load the configuration from appsettings.json
            //Configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppContext.BaseDirectory)
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .Build();

            //using var ctx = new AppDbContext();
            //ctx.Database.EnsureDeletedAsync();
            //ctx.Database.EnsureCreatedAsync();

            Application.Run(new MainView());
        }
    }
}