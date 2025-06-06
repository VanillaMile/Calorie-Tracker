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
        private int historyCurPage = 0;
        const int pageSize = 20;
        HistoryRecord hisRecord = null;
        public MainView()
        {
            InitializeComponent();
            _dbContextFactory = new AppDbContextFactory();
            minDatePick.Value = DateTime.Today.AddDays(-7);
            historyMaxDate.MaxDate = DateTime.Today;
            dateTimePickerLogFood.MaxDate = DateTime.Today;
            setUpDate();
            setFoodCB();
            setHistoryList();
        }

        private async void setHistoryList()
        {
            var minDate = historyMinDate.Value.Date;
            var maxDate = historyMaxDate.Value.Date;
            int hisPage = this.historyCurPage;
            using (var _historyService = getHistoryService())
            using (var _foodService = getFoodService())
            {
                var historyRecords = await _historyService.GetRecordsFilteredAsync(minDate, maxDate);

                var foodIds = historyRecords.Select(h => h.FoodId).Distinct().ToList();

                var foods = await _foodService.GetAllFoodsAsync();
                var foodsDict = foods.Where(f => foodIds.Contains(f.Id)).ToDictionary(f => f.Id, f => f);

                var pagedHistoryRecords = historyRecords
                    .OrderByDescending(h => h.DateTime)
                    .Skip(hisPage * pageSize)
                    .Take(pageSize)
                    .ToList();

                var displayItems = pagedHistoryRecords
                    .Select(h =>
                    {
                        foodsDict.TryGetValue(h.FoodId, out var food);
                        var foodName = food?.Name ?? "Unknown";
                        return $"{foodName} | {h.DateTime:yyyy-MM-dd} | {h.Grams:0} gram";
                    })
                    .ToList();
                if (displayItems.Any())
                {
                    historyListBox.DataSource = displayItems;
                }
                else
                {
                    if (historyCurPage > 0)
                    {
                        historyCurPage--;
                        setHistoryList();
                        if (historyCurPage == 0)
                        {
                            historyBackPage.Text = $"Poprzednia";
                        }
                        else
                        {
                            historyBackPage.Text = $"Poprzednia -> {historyCurPage - 1}";
                        }
                        historyNextPage.Text = $"Następna -> {historyCurPage + 1}";
                        return;
                    }
                    historyListBox.DataSource = null;
                }

            }
        }

        private void setUpDate()
        {
            var minDate = minDatePick.Value.Date;
            var maxDate = maxDatePick.Value.Date;

            decimal totalCal = 0m;
            using (var _foodService = getFoodService())
            {
                var _historyService = getHistoryService();
                var historyRecords = _historyService._db.History
                    .Where(h => h.DateTime >= minDate && h.DateTime <= maxDate)
                    .ToList();

                var foodIds = historyRecords.Select(h => h.FoodId).Distinct().ToList();

                var foods = _foodService._db.Foods
                    .Where(f => foodIds.Contains(f.Id))
                    .ToList();

                foreach (var record in historyRecords)
                {
                    var food = foods.FirstOrDefault(f => f.Id == record.FoodId);
                    if (food != null)
                    {
                        totalCal += food.Calorie * (record.Grams / 100);
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
                MessageBox.Show("Wybierz jedzenie.");
                return;
            }
            if (!int.TryParse(FoodsComboBox.SelectedValue?.ToString(), out int foodIdCB))
            {
                MessageBox.Show("Niepoprawny wybór.");
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
                addedLabel.Text = "Dodano!";
                setUpDate();
                setHistoryList();

                await Task.Delay(2000);
                addedLabel.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Wybierz jedzenie.");
            }
        }

        private void historyBackPage_Click(object sender, EventArgs e)
        {
            if (historyCurPage > 0)
            {
                historyCurPage--;
                setHistoryList();
            }
            if (historyCurPage == 0)
            {
                historyBackPage.Text = $"Poprzednia";
            }
            else
            {
                historyBackPage.Text = $"Poprzednia -> {historyCurPage - 1}";
            }
            historyNextPage.Text = $"Następna -> {historyCurPage + 1}";
        }

        private void historyNextPage_Click(object sender, EventArgs e)
        {
            historyCurPage++;
            setHistoryList();
            if (historyCurPage == 0)
            {
                historyBackPage.Text = $"Poprzednia";
            }
            else
            {
                historyBackPage.Text = $"Poprzednia -> {historyCurPage - 1}";
            }
            historyNextPage.Text = $"Następna -> {historyCurPage + 1}";
        }

        private async void historyDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = historyListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Wybierz rekord do usunięcia.");
                return;
            }

            int hisPage = this.historyCurPage;
            var minDate = historyMinDate.Value.Date;
            var maxDate = historyMaxDate.Value.Date;

            using (var _historyService = getHistoryService())
            {
                var historyRecords = await _historyService.GetRecordsFilteredAsync(minDate, maxDate);
                var pagedHistoryRecords = historyRecords
                    .OrderByDescending(h => h.DateTime)
                    .Skip(hisPage * pageSize)
                    .Take(pageSize)
                    .ToList();

                if (selectedIndex >= pagedHistoryRecords.Count)
                {
                    MessageBox.Show("Niepoprawny rekord.");
                    return;
                }

                var recordToDelete = pagedHistoryRecords[selectedIndex];

                var confirmResult = MessageBox.Show(
                    "Czy na pewno chcesz to usunąć?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    await _historyService.DeleteRecordAsync(recordToDelete.Id);
                    setHistoryList();
                    setUpDate();
                    if (hisRecord != null)
                    {
                        hisRecord = null;
                        setEditHistory();
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        private async void historyEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = historyListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Wybierz rekord do edycji.");
                return;
            }

            int hisPage = this.historyCurPage;
            var minDate = historyMinDate.Value.Date;
            var maxDate = historyMaxDate.Value.Date;
            using (var _foodService = getFoodService())
            using (var _historyService = getHistoryService())
            {
                var historyRecords = await _historyService.GetRecordsFilteredAsync(minDate, maxDate);

                var foodIds = historyRecords.Select(h => h.FoodId).Distinct().ToList();

                var foods = await _foodService.GetAllFoodsAsync();
                var foodsDict = foods.Where(f => foodIds.Contains(f.Id)).ToDictionary(f => f.Id, f => f);

                var pagedHistoryRecords = historyRecords
                    .OrderByDescending(h => h.DateTime)
                    .Skip(hisPage * pageSize)
                    .Take(pageSize)
                    .ToList();

                var selectedRecordId = pagedHistoryRecords[selectedIndex].Id;
                hisRecord = await _historyService.GetRecordByIdAsync(selectedRecordId);
            }
            setEditHistory();
            mainTabControl.SelectTab(editHistory);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void setEditHistory()
        {
            if (hisRecord != null)
            {
                editHistoryDate.Value = hisRecord.DateTime.Date;
                editHistoryGrams.Text = hisRecord.Grams.ToString();
                editHistoryPortion.Text = hisRecord.Portions?.ToString();
                editHistoryRecordId.Text = hisRecord.Id.ToString();

                using (var _foodService = getFoodService())
                {
                    var foods = await _foodService.GetAllFoodsAsync();
                    editHistoryCombo.DataSource = foods;
                    editHistoryCombo.DisplayMember = "Name";
                    editHistoryCombo.ValueMember = "Id";
                    editHistoryCombo.SelectedValue = hisRecord.FoodId;
                    editHistoryEditBtn.Enabled = true;
                    editHistoryEditBtn.Text = "Edytuj";
                }
            }
            else
            {
                editHistoryGrams.Text = "";
                editHistoryPortion.Text = "";
                editHistoryRecordId.Text = "";
                editHistoryCombo.DataSource = null;
                editHistoryEditBtn.Enabled = false;
                editHistoryEditBtn.Text = "Brak rekordu do edycji";
            }
        }

        private async void editHistoryEditBtn_Click(object sender, EventArgs e)
        {
            if (hisRecord == null)
            {
                MessageBox.Show("Brak rekordu do edycji.");
                return;
            }

            if (!int.TryParse(editHistoryRecordId.Text, out int recordId))
            {
                MessageBox.Show("Niepoprawny identyfikator rekordu.");
                return;
            }

            if (editHistoryCombo.SelectedValue == null || !int.TryParse(editHistoryCombo.SelectedValue.ToString(), out int foodId))
            {
                MessageBox.Show("Wybierz jedzenie.");
                return;
            }

            decimal grams;
            decimal? portions;
            if (string.IsNullOrWhiteSpace(editHistoryGrams.Text))
            {
                if (string.IsNullOrWhiteSpace(editHistoryPortion.Text))
                {
                    MessageBox.Show("Podaj ilość gramów lub porcji.");
                    return;
                }
                // Portion is set, get food and calculate grams
                if (!decimal.TryParse(editHistoryPortion.Text, out decimal parsedPortion) || parsedPortion <= 0)
                {
                    MessageBox.Show("Niepoprawna wartość porcji.");
                    return;
                }
                if (editHistoryCombo.SelectedValue == null || !int.TryParse(editHistoryCombo.SelectedValue.ToString(), out int foodIdForPortion))
                {
                    MessageBox.Show("Wybierz jedzenie.");
                    return;
                }
                using (var _foodService = getFoodService())
                {
                    var food = await _foodService.GetFoodByIdAsync(foodIdForPortion);
                    if (food == null)
                    {
                        MessageBox.Show("Nie znaleziono jedzenia.");
                        return;
                    }
                    grams = food.GramsInPortion * parsedPortion;
                }
                portions = parsedPortion;
            }
            else
            {
                // Grams is set, validate
                if (!decimal.TryParse(editHistoryGrams.Text, out grams) || grams <= 0)
                {
                    MessageBox.Show("Niepoprawna wartość gramów.");
                    return;
                }
                // Portion is optional
                portions = null;
                if (!string.IsNullOrWhiteSpace(editHistoryPortion.Text))
                {
                    if (decimal.TryParse(editHistoryPortion.Text, out decimal parsedPortion) && parsedPortion > 0)
                    {
                        portions = parsedPortion;
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawna wartość porcji.");
                        return;
                    }
                }
            }

            var date = editHistoryDate.Value.Date;

            // Update the record
            using (var _historyService = getHistoryService())
            {
                var recordToUpdate = await _historyService.GetRecordByIdAsync(recordId);
                if (recordToUpdate == null)
                {
                    MessageBox.Show("Nie znaleziono rekordu do edycji.");
                    return;
                }

                recordToUpdate.DateTime = date;
                recordToUpdate.Grams = grams;
                recordToUpdate.Portions = portions;
                recordToUpdate.FoodId = foodId;

                await _historyService.UpdateRecordAsync(recordToUpdate);
            }

            editHistoryLabel.Text = "Zaktualizowano";
            hisRecord = null;
            setEditHistory();
            setHistoryList();
            setUpDate();
            await Task.Delay(2000);
            editHistoryLabel.Text = "Zaktualizowano";
        }

        private void historyMinDate_ValueChanged(object sender, EventArgs e)
        {
            setHistoryList();
        }

        private void historyMaxDate_ValueChanged(object sender, EventArgs e)
        {
            setHistoryList();
        }
    }
}
