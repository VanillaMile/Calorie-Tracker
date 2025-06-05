using Calorie_Tracker.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Tracker
{
    public partial class MainView : Form
    {
        private readonly AppDbContextFactory _dbContextFactory;
        public MainView()
        {
            InitializeComponent();
            _dbContextFactory = new AppDbContextFactory();
        }

        private FoodsService getFoodService()
        {
            var dbContext = _dbContextFactory.CreateDbContext(Array.Empty<string>()); // Use Array.Empty<string>() to avoid unnecessary zero-length array allocations  
            FoodsService _foodsService = new FoodsService(dbContext);
            return _foodsService;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Food food = new Food
            {
                Name = "Example Food",
                Calorie = 100.0m,
                GramsInPortion = 50.0m,
                Fats = 5.0m,
                Salts = 1.0m,
                Protein = 10.0m,
                Caffeine = 0.0m
            };

            using (var _foodService = getFoodService())
            {
                await getFoodService().CreateFoodAsync(food);
            }
        }
    }
}
