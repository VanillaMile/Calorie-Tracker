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
            minDatePick.Value = DateTime.Today.AddDays(-7);
            setUpDate();
            setFoodCB();
        }

        private void setUpDate()
        {
            var minDate = minDatePick.Value.Date;
            var maxDate = maxDatePick.Value.Date;

            decimal totalCal = 0m;
            using (var _foodService = getFoodService())
            {
                var _historyService = getHistoryService();
                // Get all history records within the date range
                var historyRecords = _historyService._db.History
                    .Where(h => h.DateTime >= minDate && h.DateTime <= maxDate)
                    .ToList();

                // Get all food IDs from history
                var foodIds = historyRecords.Select(h => h.FoodId).Distinct().ToList();

                // Get all foods referenced in history
                var foods = _foodService._db.Foods
                    .Where(f => foodIds.Contains(f.Id))
                    .ToList();

                // Sum calories for each history record
                foreach (var record in historyRecords)
                {
                    var food = foods.FirstOrDefault(f => f.Id == record.FoodId);
                    if (food != null)
                    {
                        totalCal += food.Calorie;
                    }
                }
            }

            totalCalorieConsumedValue.Text = totalCal.ToString("0");
            daysValue.Text = ((maxDate - minDate).Days + 1).ToString();
            caloriePerDayValue.Text = ((maxDate - minDate).Days + 1 > 0 ? (totalCal / ((maxDate - minDate).Days + 1)) : 0).ToString("0");
        }

        private async void setFoodCB()
        {
            using (var _foodService = getFoodService())
            {
                var foods = await _foodService.GetAllFoodsAsync();

                FoodsComboBox.DataSource = foods;
                FoodsComboBox.DisplayMember = "Name";
                FoodsComboBox.ValueMember = "Id";
            }
        }

        private FoodsService getFoodService()
        {
            var dbContext = _dbContextFactory.CreateDbContext(Array.Empty<string>()); // Use Array.Empty<string>() to avoid unnecessary zero-length array allocations  
            FoodsService _foodsService = new FoodsService(dbContext);
            return _foodsService;
        }
        private HistoryService getHistoryService()
        {
            var dbContext = _dbContextFactory.CreateDbContext(Array.Empty<string>()); // Use Array.Empty<string>() to avoid unnecessary zero-length array allocations  
            HistoryService _historyService = new HistoryService(dbContext);
            return _historyService;
        }

        private async void refreshBtn_click(object sender, EventArgs e)
        {
            setUpDate();
        }

        private async void addFoodHistoryRecord_Click(object sender, EventArgs e)
        {
            if (FoodsComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a food.");
                return;
            }
            if (!int.TryParse(FoodsComboBox.SelectedValue?.ToString(), out int foodIdCB))
            {
                MessageBox.Show("Invalid food selection.");
                return;
            }

            var selectedDate = dateTimePickerLogFood.Value.Date;
            Food? specificFood = null;
            using (var _foodService = getFoodService())
            {
                specificFood = await _foodService.GetFoodByIdAsync(foodIdCB);
            }

            decimal grams = 0m;
            decimal? portions = null;
            if (gramsUpDown.Value != 0)
                grams = gramsUpDown.Value;
            if (portionUpDown.Value != 0)
                portions = portionUpDown.Value;

            if ((gramsUpDown.Value == 0) && (portionUpDown.Value == 0))
            {
                grams = specificFood.GramsInPortion;
            }
            if (gramsUpDown.Value == 0 && portionUpDown.Value > 0)
            {
                grams = specificFood.GramsInPortion * portionUpDown.Value;
            }

            if (grams > 0)
            {
                using (var _historyService = getHistoryService())
                {
                    var newRecord = new HistoryRecord
                    {
                        DateTime = selectedDate,
                        Grams = grams,
                        Portions = portions,
                        FoodId = foodIdCB
                    };
                    await _historyService.CreateRecordAsync(newRecord);
                }
                addedLabel.Text = "Added!";
                setUpDate();

                await Task.Delay(2000);
                addedLabel.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select a food.");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
