using Calorie_Tracker.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // FIXME: This is here temporary until I fix the builder
        optionsBuilder.UseNpgsql(@"Server=localhost;User Id=postgres;Password=SatoriSama;Database=CalorieDB;");

        return new AppDbContext(optionsBuilder.Options);
    }
}