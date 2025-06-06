using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Tracker.data
{
    public class AppDbContext : DbContext
    {
        

        //private readonly IConfiguration _configuration;

        //public AppDbContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Food> Foods { get; set; }
        public DbSet<HistoryRecord> History { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Alter with fluent API
            modelBuilder.Entity<HistoryRecord>()
               .Property(h => h.DateTime)
               .HasColumnType("date");

            modelBuilder.Entity<Note>()
               .Property(h => h.DateTime)
               .HasColumnType("date");

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Food>().HasData(
                new Food { Id = 1, Name = "Pizza", Calorie = 300m, Fats = 13.4m, Salts = 14m, Protein = 10m, GramsInPortion = 132 },
                new Food { Id = 2, Name = "Spaghetti", Calorie = 225m, Fats = 16.4m, Salts = 18m, Protein = 20m, GramsInPortion = 140 },
                new Food { Id = 3, Name = "Chicken Breast", Calorie = 165m, Fats = 3.6m, Salts = 0.7m, Protein = 31m, GramsInPortion = 100 },
                new Food { Id = 4, Name = "Apple", Calorie = 90m, Fats = 0.2m, Salts = 0m, Protein = 0.3m, GramsInPortion = 150 },
                new Food { Id = 5, Name = "Banana", Calorie = 100m, Fats = 0.3m, Salts = 0m, Protein = 1.1m, GramsInPortion = 120 },
                new Food { Id = 6, Name = "Broccoli", Calorie = 120m, Fats = 0.6m, Salts = 0.05m, Protein = 3.7m, GramsInPortion = 100 },
                new Food { Id = 7, Name = "Salmon", Calorie = 208m, Fats = 13m, Salts = 0.1m, Protein = 20m, GramsInPortion = 100 },
                new Food { Id = 8, Name = "Avocado", Calorie = 90m, Fats = 15m, Salts = 0.01m, Protein = 2m, GramsInPortion = 100 },
                new Food { Id = 9, Name = "Rice", Calorie = 200m, Fats = 0.3m, Salts = 0m, Protein = 2.7m, GramsInPortion = 100 },
                new Food { Id = 10, Name = "Cheeseburger", Calorie = 303m, Fats = 14m, Salts = 1.2m, Protein = 17m, GramsInPortion = 120 },
                new Food { Id = 11, Name = "French Fries", Calorie = 312m, Fats = 15m, Salts = 0.6m, Protein = 3.4m, GramsInPortion = 100 },
                new Food { Id = 12, Name = "Orange", Calorie = 90m, Fats = 0.1m, Salts = 0m, Protein = 0.9m, GramsInPortion = 130 },
                new Food { Id = 13, Name = "Egg", Calorie = 155m, Fats = 11m, Salts = 0.1m, Protein = 13m, GramsInPortion = 60 },
                new Food { Id = 14, Name = "Milk", Calorie = 42m, Fats = 1m, Salts = 0.05m, Protein = 3.4m, GramsInPortion = 100 },
                new Food { Id = 15, Name = "Yogurt", Calorie = 59m, Fats = 0.4m, Salts = 0.1m, Protein = 10m, GramsInPortion = 150 },
                new Food { Id = 16, Name = "Peanut Butter", Calorie = 588m, Fats = 50m, Salts = 1.2m, Protein = 25m, GramsInPortion = 100 },
                new Food { Id = 17, Name = "Almonds", Calorie = 579m, Fats = 49m, Salts = 0m, Protein = 21m, GramsInPortion = 100 },
                new Food { Id = 18, Name = "Oatmeal", Calorie = 68m, Fats = 1.4m, Salts = 0m, Protein = 2.4m, GramsInPortion = 40 },
                new Food { Id = 19, Name = "Tea", Calorie = 1m, Fats = 0m, Salts = 0m, Protein = 0m, GramsInPortion = 250, Caffeine = 47m },
                new Food { Id = 20, Name = "Coffee", Calorie = 2m, Fats = 0m, Salts = 0m, Protein = 0.3m, GramsInPortion = 250, Caffeine = 95m }
            );

            modelBuilder.Entity<HistoryRecord>().HasData(
                new HistoryRecord { Id = 1, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 5, 21), DateTimeKind.Utc), Grams = 181.6m, Portions = 3.1m, FoodId = 20 },
                new HistoryRecord { Id = 2, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 6, 24), DateTimeKind.Utc), Grams = 289.6m, Portions = 2.1m, FoodId = 18 },
                new HistoryRecord { Id = 3, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 5, 18), DateTimeKind.Utc), Grams = 391.6m, Portions = 3.1m, FoodId = 11 },
                new HistoryRecord { Id = 4, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 6, 3),  DateTimeKind.Utc), Grams = 277.2m, Portions = 1.1m, FoodId = 6 },
                new HistoryRecord { Id = 5, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 6, 24), DateTimeKind.Utc), Grams = 163.3m, Portions = 2.8m, FoodId = 14 },
                new HistoryRecord { Id = 6, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 6, 14), DateTimeKind.Utc), Grams = 242.7m, Portions = 2.1m, FoodId = 11 },
                new HistoryRecord { Id = 7, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 6, 30), DateTimeKind.Utc), Grams = 366.1m, Portions = 0.6m, FoodId = 3 },
                new HistoryRecord { Id = 8, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 6, 27), DateTimeKind.Utc), Grams = 121.1m, Portions = 3.2m, FoodId = 11 },
                new HistoryRecord { Id = 9, DateTime =  DateTime.SpecifyKind(new DateTime(2025, 6, 10), DateTimeKind.Utc), Grams = 260.1m, Portions = 1.5m, FoodId = 18 },
                new HistoryRecord { Id = 10, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 28), DateTimeKind.Utc), Grams = 196.3m, Portions = 3.2m, FoodId = 14 },
                new HistoryRecord { Id = 11, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 18), DateTimeKind.Utc), Grams = 117.9m, Portions = 1.1m, FoodId = 13 },
                new HistoryRecord { Id = 12, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 28), DateTimeKind.Utc), Grams = 303.0m, Portions = 3.0m, FoodId = 10 },
                new HistoryRecord { Id = 13, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 3),  DateTimeKind.Utc), Grams = 329.5m, Portions = 2.7m, FoodId = 9 },
                new HistoryRecord { Id = 14, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 25), DateTimeKind.Utc), Grams = 299.3m, Portions = 2.0m, FoodId = 9 },
                new HistoryRecord { Id = 15, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 25), DateTimeKind.Utc), Grams = 262.1m, Portions = 1.2m, FoodId = 19 },
                new HistoryRecord { Id = 16, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 17), DateTimeKind.Utc), Grams = 343.3m, Portions = 0.5m, FoodId = 9 },
                new HistoryRecord { Id = 17, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 6),  DateTimeKind.Utc), Grams = 299.7m, Portions = 1.2m, FoodId = 6 },
                new HistoryRecord { Id = 18, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 29), DateTimeKind.Utc), Grams = 127.9m, Portions = 1.8m, FoodId = 17 },
                new HistoryRecord { Id = 19, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 13), DateTimeKind.Utc), Grams = 168.3m, Portions = 2.2m, FoodId = 14 },
                new HistoryRecord { Id = 20, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 19), DateTimeKind.Utc), Grams = 326.9m, Portions = 2.7m, FoodId = 8 },
                new HistoryRecord { Id = 21, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 30), DateTimeKind.Utc), Grams = 77.4m, Portions = 2.8m, FoodId = 14 },
                new HistoryRecord { Id = 22, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 23), DateTimeKind.Utc), Grams = 378.5m, Portions = 2.2m, FoodId = 18 },
                new HistoryRecord { Id = 23, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 16), DateTimeKind.Utc), Grams = 236.6m, Portions = 0.7m, FoodId = 2 },
                new HistoryRecord { Id = 24, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 18), DateTimeKind.Utc), Grams = 205.0m, Portions = 1.3m, FoodId = 19 },
                new HistoryRecord { Id = 25, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 6),  DateTimeKind.Utc), Grams = 178.2m, Portions = 1.9m, FoodId = 3 },
                new HistoryRecord { Id = 26, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 16), DateTimeKind.Utc), Grams = 185.4m, Portions = 2.0m, FoodId = 15 },
                new HistoryRecord { Id = 27, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 29), DateTimeKind.Utc), Grams = 196.3m, Portions = 1.9m, FoodId = 12 },
                new HistoryRecord { Id = 28, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 29), DateTimeKind.Utc), Grams = 372.0m, Portions = 1.2m, FoodId = 18 },
                new HistoryRecord { Id = 29, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 26), DateTimeKind.Utc), Grams = 319.7m, Portions = 1.7m, FoodId = 6 },
                new HistoryRecord { Id = 30, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 20), DateTimeKind.Utc), Grams = 51.0m, Portions = 1.8m, FoodId = 3 },
                new HistoryRecord { Id = 31, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 27), DateTimeKind.Utc), Grams = 324.6m, Portions = 2.8m, FoodId = 20 },
                new HistoryRecord { Id = 32, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 28), DateTimeKind.Utc), Grams = 398.8m, Portions = 2.6m, FoodId = 9 },
                new HistoryRecord { Id = 33, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 18), DateTimeKind.Utc), Grams = 336.8m, Portions = 1.8m, FoodId = 5 },
                new HistoryRecord { Id = 34, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 6),  DateTimeKind.Utc), Grams = 397.5m, Portions = 1.2m, FoodId = 2 },
                new HistoryRecord { Id = 35, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 14), DateTimeKind.Utc), Grams = 342.9m, Portions = 0.9m, FoodId = 5 },
                new HistoryRecord { Id = 36, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 18), DateTimeKind.Utc), Grams = 370.7m, Portions = 2.0m, FoodId = 1 },
                new HistoryRecord { Id = 37, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 18), DateTimeKind.Utc), Grams = 121.8m, Portions = 3.1m, FoodId = 6 },
                new HistoryRecord { Id = 38, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 28), DateTimeKind.Utc), Grams = 219.5m, Portions = 1.9m, FoodId = 3 },
                new HistoryRecord { Id = 39, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 30), DateTimeKind.Utc), Grams = 98.6m, Portions = 2.0m, FoodId = 5 },
                new HistoryRecord { Id = 40, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 11), DateTimeKind.Utc), Grams = 275.0m, Portions = 2.5m, FoodId = 5 },
                new HistoryRecord { Id = 41, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 8),  DateTimeKind.Utc), Grams = 384.1m, Portions = 0.5m, FoodId = 8 },
                new HistoryRecord { Id = 42, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 5),  DateTimeKind.Utc), Grams = 301.1m, Portions = 3.3m, FoodId = 4 },
                new HistoryRecord { Id = 43, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 3),  DateTimeKind.Utc), Grams = 135.6m, Portions = 3.1m, FoodId = 12 },
                new HistoryRecord { Id = 44, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 12), DateTimeKind.Utc), Grams = 102.7m, Portions = 1.2m, FoodId = 10 },
                new HistoryRecord { Id = 45, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 25), DateTimeKind.Utc), Grams = 138.2m, Portions = 1.7m, FoodId = 17 },
                new HistoryRecord { Id = 46, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 26), DateTimeKind.Utc), Grams = 386.8m, Portions = 2.3m, FoodId = 9 },
                new HistoryRecord { Id = 47, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 26), DateTimeKind.Utc), Grams = 297.0m, Portions = 1.2m, FoodId = 11 },
                new HistoryRecord { Id = 48, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 6),  DateTimeKind.Utc), Grams = 177.7m, Portions = 2.7m, FoodId = 15 },
                new HistoryRecord { Id = 49, DateTime = DateTime.SpecifyKind(new DateTime(2025, 5, 20), DateTimeKind.Utc), Grams = 371.6m, Portions = 2.7m, FoodId = 15 },
                new HistoryRecord { Id = 50, DateTime = DateTime.SpecifyKind(new DateTime(2025, 6, 8),  DateTimeKind.Utc), Grams = 384.2m, Portions = 2.1m, FoodId = 17 }
            );


            modelBuilder.Entity<Note>().HasData(
                new Note { Id = 1, DateTime = new DateTime(2025, 6, 1), FoodId = 1, Noted = "Leftover pizza" },
                new Note { Id = 2, DateTime = new DateTime(2025, 6, 3), FoodId = 4, Noted = "Too salty, reduce portion next time" },
                new Note { Id = 3, DateTime = new DateTime(2025, 6, 5), FoodId = 7, Noted = "Tried grilled tofu, decent protein source" },
                new Note { Id = 4, DateTime = new DateTime(2025, 6, 12), FoodId = 13, Noted = "Had too much chocolate" },
                new Note { Id = 5, DateTime = new DateTime(2025, 6, 14), FoodId = 19, Noted = "Coffee gave slight jitters, reduce caffeine?" },

                new Note { Id = 6, DateTime = new DateTime(2025, 6, 2), Noted = "Skipped breakfast" },
                new Note { Id = 7, DateTime = new DateTime(2025, 6, 6), Noted = "Felt energetic after lunch" },
                new Note { Id = 8, DateTime = new DateTime(2025, 6, 9), Noted = "Meal timing was off" },
                new Note { Id = 9, DateTime = new DateTime(2025, 6, 15), Noted = "Try more vegetarian meals next week" },
                new Note { Id = 10, DateTime = new DateTime(2025, 6, 18), Noted = "Late dinner caused bloating" }
            );
        }
    }
}
