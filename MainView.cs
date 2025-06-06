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
            setFoodList();
            setUpAddNote();
            setUpNoteHistory();
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

        private NoteService getNoteService()
        {
            var dbContext = _dbContextFactory.CreateDbContext(Array.Empty<string>()); // Use Array.Empty<string>() to avoid unnecessary zero-length array allocations  
            NoteService _noteService = new NoteService(dbContext);
            return _noteService;
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
            mainTabControl.SelectTab(historyPage);
            editHistoryLabel.Text = "";
        }

        private void historyMinDate_ValueChanged(object sender, EventArgs e)
        {
            setHistoryList();
        }

        private void historyMaxDate_ValueChanged(object sender, EventArgs e)
        {
            setHistoryList();
        }

        private List<Food> filteredFoods;
        private const int foodPageSize = 20;
        private int foodsCurPage;
        private string searchPhrase;
        private Food toEditFood = null;
        async void setFoodList()
        {
            using (var _foodService = getFoodService())
            {
                var foods = await _foodService.GetAllFoodsAsync();
                if (string.IsNullOrEmpty(searchPhrase))
                {
                    filteredFoods = foods
                        .Skip(foodsCurPage * foodPageSize)
                        .Take(foodPageSize)
                        .ToList();
                }
                else
                {
                    filteredFoods = foods
                        .Where(f => f.Name.Contains(searchPhrase, StringComparison.OrdinalIgnoreCase))
                        .Skip(foodsCurPage * foodPageSize)
                        .Take(foodPageSize)
                        .ToList();
                }
                if (filteredFoods.Count == 0 && foodsCurPage != 0)
                {
                    foodsCurPage--;
                    setFoodList();
                    return;
                }

                foodListBox.DataSource = filteredFoods;
                foodListBox.DisplayMember = "Name";
                foodListBox.ValueMember = "Id";
            }
        }

        private void foodSearchBtn_Click(object sender, EventArgs e)
        {
            searchPhrase = foodSearchBox.Text;
            setFoodList();
        }

        private void foodNextBtn_Click(object sender, EventArgs e)
        {
            foodsCurPage++;
            setFoodList();
        }

        private void foodBackBtn_Click(object sender, EventArgs e)
        {
            if (foodsCurPage > 0)
            {
                foodsCurPage--;
                setFoodList();
            }
        }

        private void foodSearchBox_TextChanged_1(object sender, EventArgs e)
        {
            searchPhrase = foodSearchBox.Text;
            setFoodList();
        }

        private void foodListBox_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = foodListBox.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var foodInfoForm = new showFoodInfo(filteredFoods[index]);
                foodInfoForm.Show();

            }
        }

        private async void foodDeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = foodListBox.SelectedIndex;
            if (selectedIndex < 0 || filteredFoods == null || selectedIndex >= filteredFoods.Count)
            {
                MessageBox.Show("Wybierz jedzenie do usunięcia.");
                return;
            }

            var foodToDelete = filteredFoods[selectedIndex];

            var confirmResult = MessageBox.Show(
                $"Czy chcesz usunąć '{foodToDelete.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (var _foodService = getFoodService())
                {
                    await _foodService.DeleteFoodAsync(foodToDelete.Id);
                }
                setFoodList();
                setUpAddNote();
                toEditFood = null;
                editFoodUpdateBTN.Enabled = false;
                editFoodUpdateBTN.Text = "Brak rekordu do edycji";
            }
        }

        private void foodEditBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = foodListBox.SelectedIndex;
            if (selectedIndex < 0 || filteredFoods == null || selectedIndex >= filteredFoods.Count)
            {
                MessageBox.Show("Wybierz jedzenie do edycji.");
                return;
            }

            toEditFood = filteredFoods[selectedIndex];

            editFoodName.Text = toEditFood.Name;
            editFoodCalorie.Text = toEditFood.Calorie.ToString("0.##");
            editFoodFats.Text = toEditFood.Fats?.ToString("0.##") ?? "";
            editFoodSalts.Text = toEditFood.Salts?.ToString("0.##") ?? "";
            editFoodProtein.Text = toEditFood.Protein?.ToString("0.##") ?? "";
            editFoodCaffeine.Text = toEditFood.Caffeine?.ToString("0.##") ?? "";
            editFoodGramsInPortion.Text = toEditFood.GramsInPortion.ToString("0.##");

            editFoodUpdateBTN.Enabled = true;
            editFoodUpdateBTN.Text = "Edytuj";
            mainTabControl.SelectTab(editFood);
        }

        private async void editFoodUpdateBTN_Click(object sender, EventArgs e)
        {
            if (toEditFood == null)
            {
                MessageBox.Show("No food selected for editing.");
                return;
            }

            string name = editFoodName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (!decimal.TryParse(editFoodCalorie.Text, out decimal calorie) || calorie < 0)
            {
                MessageBox.Show("Calorie must be a non-negative number.");
                return;
            }

            if (!decimal.TryParse(editFoodGramsInPortion.Text, out decimal gramsInPortion) || gramsInPortion <= 0)
            {
                MessageBox.Show("Grams in portion must be a positive number.");
                return;
            }

            decimal? fats = null, salts = null, protein = null, caffeine = null;

            if (string.IsNullOrWhiteSpace(editFoodFats.Text) || !decimal.TryParse(editFoodFats.Text, out decimal fatsVal))
            {
                MessageBox.Show("Fats is required and must be a number.");
                return;
            }
            fats = fatsVal;

            if (string.IsNullOrWhiteSpace(editFoodSalts.Text) || !decimal.TryParse(editFoodSalts.Text, out decimal saltsVal))
            {
                MessageBox.Show("Salts is required and must be a number.");
                return;
            }
            salts = saltsVal;

            if (string.IsNullOrWhiteSpace(editFoodProtein.Text) || !decimal.TryParse(editFoodProtein.Text, out decimal proteinVal))
            {
                MessageBox.Show("Protein is required and must be a number.");
                return;
            }
            protein = proteinVal;

            if (!string.IsNullOrWhiteSpace(editFoodCaffeine.Text))
            {
                if (!decimal.TryParse(editFoodCaffeine.Text, out decimal caffeineVal))
                {
                    MessageBox.Show("Caffeine must be a number or empty.");
                    return;
                }
                caffeine = caffeineVal;
            }

            // Update food
            toEditFood.Name = name;
            toEditFood.Calorie = calorie;
            toEditFood.Fats = fats;
            toEditFood.Salts = salts;
            toEditFood.Protein = protein;
            toEditFood.Caffeine = caffeine;
            toEditFood.GramsInPortion = gramsInPortion;

            editFoodName.Text = "";
            editFoodCalorie.Text = "";
            editFoodFats.Text = "";
            editFoodSalts.Text = "";
            editFoodProtein.Text = "";
            editFoodCaffeine.Text = "";
            editFoodGramsInPortion.Text = "";

            using (var _foodService = getFoodService())
            {
                await _foodService.UpdateFoodAsync(toEditFood);
            }

            editFoodLBL.Text = "Zaktualizowano";
            editFoodUpdateBTN.Enabled = false;
            editFoodUpdateBTN.Text = "Brak rekordu do edycji";
            setFoodList();
            setFoodCB();
            setUpAddNote();
            await Task.Delay(2000);
            mainTabControl.SelectTab(foodsPage);
            toEditFood = null;
            editFoodLBL.Text = "";
        }

        private async void setUpAddNote()
        {
            using (var _foodService = getFoodService())
            {
                var foods = await _foodService.GetAllFoodsAsync();

                addNoteCB.DataSource = foods;
                addNoteCB.DisplayMember = "Name";
                addNoteCB.ValueMember = "Id";
            }
        }

        private void addNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = addNoteTextBox.Text;
            if (string.IsNullOrWhiteSpace(input) || addNoteCB.DataSource == null)
                return;

            var foods = addNoteCB.DataSource as IEnumerable<Food>;
            if (foods == null)
                return;

            var words = input.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-', '_', '/', '\\', '\'', '\"', '(', ')', '[', ']', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            var match = foods.FirstOrDefault(f =>
                !string.IsNullOrWhiteSpace(f.Name) &&
                words.Any(word => string.Equals(word, f.Name, StringComparison.OrdinalIgnoreCase))
            );

            if (match != null)
            {
                addNoteCB.SelectedValue = match.Id;
                return;
            }

            match = foods.FirstOrDefault(f =>
                !string.IsNullOrWhiteSpace(f.Name) &&
                words.Any(word =>
                    string.Equals(word, f.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? "", StringComparison.OrdinalIgnoreCase))
            );

            if (match != null)
            {
                addNoteCB.SelectedValue = match.Id;
                return;
            }

            try
            {
                var regex = new System.Text.RegularExpressions.Regex(input, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                match = foods.FirstOrDefault(f => regex.IsMatch(f.Name));
                if (match != null)
                {
                    addNoteCB.SelectedValue = match.Id;
                }
            }
            catch (ArgumentException)
            {
                // Invalid regex pattern, ignore
            }
        }

        private async void addNoteAddBTN_Click(object sender, EventArgs e)
        {
            string noteText = addNoteTextBox.Text?.Trim();
            if (string.IsNullOrWhiteSpace(noteText))
            {
                MessageBox.Show("Note text is required.");
                return;
            }

            DateTime noteDate = addNoteDate.Value.Date;
            int? foodId = null;

            if (addNoteCheckBox.Checked)
            {
                if (addNoteCB.SelectedValue == null || !int.TryParse(addNoteCB.SelectedValue.ToString(), out int parsedFoodId))
                {
                    MessageBox.Show("Select a valid food item.");
                    return;
                }
                foodId = parsedFoodId;
            }

            var note = new Note
            {
                DateTime = noteDate,
                Noted = noteText,
                FoodId = foodId
            };

            using (var noteService = getNoteService())
            {
                await noteService.CreateNoteAsync(note);
            }

            addNoteLBL.Text = "Dodano!";
            addNoteTextBox.Text = "";
            setUpNoteHistory();
            await Task.Delay(2000);
            addNoteLBL.Text = "";
        }

        private async void addFoodBtn_Click(object sender, EventArgs e)
        {
            string name = addFoodName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (!decimal.TryParse(addFoodCalorie.Text, out decimal calorie) || calorie < 0)
            {
                MessageBox.Show("Calorie must be a non-negative number.");
                return;
            }

            if (!decimal.TryParse(addFoodFats.Text, out decimal fats))
            {
                MessageBox.Show("Fats is required and must be a number.");
                return;
            }

            if (!decimal.TryParse(addFoodSalts.Text, out decimal salts))
            {
                MessageBox.Show("Salts is required and must be a number.");
                return;
            }

            if (!decimal.TryParse(addFoodProteine.Text, out decimal protein))
            {
                MessageBox.Show("Protein is required and must be a number.");
                return;
            }

            if (!decimal.TryParse(addFoodGramsInPortion.Text, out decimal gramsInPortion) || gramsInPortion <= 0)
            {
                MessageBox.Show("Grams in portion must be a positive number.");
                return;
            }

            decimal? caffeine = null;
            if (!string.IsNullOrWhiteSpace(addFoodCafeine.Text))
            {
                if (!decimal.TryParse(addFoodCafeine.Text, out decimal caffeineVal))
                {
                    MessageBox.Show("Caffeine must be a number or empty.");
                    return;
                }
                caffeine = caffeineVal;
            }

            var newFood = new Food
            {
                Name = name,
                Calorie = calorie,
                Fats = fats,
                Salts = salts,
                Protein = protein,
                Caffeine = caffeine,
                GramsInPortion = gramsInPortion
            };

            using (var _foodService = getFoodService())
            {
                await _foodService.CreateFoodAsync(newFood);
            }

            addFoodName.Text = "";
            addFoodCalorie.Text = "";
            addFoodFats.Text = "";
            addFoodSalts.Text = "";
            addFoodProteine.Text = "";
            addFoodCafeine.Text = "";
            addFoodGramsInPortion.Text = "";

            addFoodLBL.Text = "Dodano!";
            setFoodList();
            setFoodCB();
            setUpAddNote();
            await Task.Delay(2000);
            addFoodLBL.Text = "";
        }

        private List<Note> filteredNotes;
        private const int notePageSize = 20;
        private int notesCurPage;
        private Note toEditNote = null;
        private async void setUpNoteHistory()
        {
            var minDate = historyNoteDateMin.Value.Date;
            var maxDate = historyNoteDateMax.Value.Date;
            int page = notesCurPage;

            using (var noteService = getNoteService())
            {
                var allNotes = await noteService.GetNotesFilteredAsync(minDate, maxDate);
                filteredNotes = allNotes
                    .OrderByDescending(n => n.DateTime)
                    .Skip(page * notePageSize)
                    .Take(notePageSize)
                    .ToList();

                // FIXME: Fix n.Food being null despite having FoodId
                var notesWithNames = filteredNotes
                    .Select(n => (n.Food != null)
                        ? $"{n.Noted} | {n.Food.Name}"
                        : n.Noted)
                    .ToArray();

                if (notesWithNames.Any())
                {
                    historyNoteListBox.DataSource = notesWithNames;
                }
                else
                {
                    if (notesCurPage != 0)
                    {
                        notesCurPage--;
                        setUpNoteHistory();
                        return;
                    }
                    historyNoteListBox.DataSource = null;
                }
            }
        }

        private async void historyNoteDeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = historyNoteListBox.SelectedIndex;
            if (selectedIndex < 0 || filteredNotes == null || selectedIndex >= filteredNotes.Count)
            {
                MessageBox.Show("Wybierz notatkę do usunięcia.");
                return;
            }

            var noteToDelete = filteredNotes[selectedIndex];

            var confirmResult = MessageBox.Show(
                $"Czy chcesz usunąć tę notatkę?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (var noteService = getNoteService())
                {
                    await noteService.DeleteNoteAsync(noteToDelete.Id);
                }
                setUpNoteHistory();
                toEditNote = null;
                editNoteBtn.Enabled = true;
                editNoteBtn.Text = "Edytuj";
            }
        }

        private void historyNoteBackBtn_Click(object sender, EventArgs e)
        {
            if (notesCurPage > 0)
            {
                notesCurPage--;
                setUpNoteHistory();
            }
        }

        private void historyNoteNextBtn_Click(object sender, EventArgs e)
        {
            notesCurPage++;
            setUpNoteHistory();
        }

        private void historyNoteDateMin_ValueChanged(object sender, EventArgs e)
        {
            setUpNoteHistory();
        }

        private void historyNoteDateMax_ValueChanged(object sender, EventArgs e)
        {
            setUpNoteHistory();
        }

        private async void historyNoteEditBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = historyNoteListBox.SelectedIndex;
            if (selectedIndex < 0 || filteredNotes == null || selectedIndex >= filteredNotes.Count)
            {
                MessageBox.Show("Wybierz notatkę do edycji.");
                return;
            }

            var noteToEdit = filteredNotes[selectedIndex];


            editNoteDate.Value = noteToEdit.DateTime.Date;
            editNoteNoted.Text = noteToEdit.Noted;

            using (var foodService = getFoodService())
            {
                var foods = await foodService.GetAllFoodsAsync();
                editNoteCB.DataSource = foods;
                editNoteCB.DisplayMember = "Name";
                editNoteCB.ValueMember = "Id";

            }

            if (noteToEdit.FoodId.HasValue)
            {
                editNoteCheckBox.Checked = true;
                using (var foodService = getFoodService())
                {
                    var foods = await foodService.GetAllFoodsAsync();
                    editNoteCB.SelectedValue = noteToEdit.FoodId.Value;
                }
            }
            else
            {
                editNoteCheckBox.Checked = false;
                editNoteCB.SelectedIndex = -1;
            }

            toEditNote = noteToEdit;

            mainTabControl.SelectTab(editNote);
            editNoteBtn.Enabled = true;
            editNoteBtn.Text = "Edytuj";
        }

        private async void editNoteBtn_Click(object sender, EventArgs e)
        {
            if (toEditNote == null)
            {
                MessageBox.Show("No note selected for editing.");
                return;
            }

            string noteText = editNoteNoted.Text?.Trim();
            if (string.IsNullOrWhiteSpace(noteText))
            {
                MessageBox.Show("Note text is required.");
                return;
            }

            DateTime noteDate = editNoteDate.Value.Date;
            int? foodId = null;

            if (editNoteCheckBox.Checked)
            {
                if (editNoteCB.SelectedValue == null || !int.TryParse(editNoteCB.SelectedValue.ToString(), out int parsedFoodId))
                {
                    MessageBox.Show("Select a valid food item.");
                    return;
                }
                foodId = parsedFoodId;
            }

            // Update note
            toEditNote.DateTime = noteDate;
            toEditNote.Noted = noteText;
            toEditNote.FoodId = foodId;

            using (var noteService = getNoteService())
            {
                await noteService.UpdateNoteAsync(toEditNote);
            }

            editNoteLBL.Text = "Zaktualizowano";
            editNoteBtn.Enabled = false;
            editNoteBtn.Text = "Brak rekordu do edycji";
            setUpNoteHistory();
            await Task.Delay(2000);
            mainTabControl.SelectTab(notesPage);
            editNoteLBL.Text = "";
            toEditNote = null;
        }

        private void editNoteNoted_TextChanged(object sender, EventArgs e)
        {
            string input = editNoteNoted.Text;
            if (string.IsNullOrWhiteSpace(input) || editNoteCB.DataSource == null)
                return;

            var foods = editNoteCB.DataSource as IEnumerable<Food>;
            if (foods == null)
                return;

            var words = input.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-', '_', '/', '\\', '\'', '\"', '(', ')', '[', ']', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            var match = foods.FirstOrDefault(f =>
                !string.IsNullOrWhiteSpace(f.Name) &&
                words.Any(word => string.Equals(word, f.Name, StringComparison.OrdinalIgnoreCase))
            );

            if (match != null)
            {
                editNoteCB.SelectedValue = match.Id;
                return;
            }

            match = foods.FirstOrDefault(f =>
                !string.IsNullOrWhiteSpace(f.Name) &&
                words.Any(word =>
                    string.Equals(word, f.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? "", StringComparison.OrdinalIgnoreCase))
            );

            if (match != null)
            {
                editNoteCB.SelectedValue = match.Id;
                return;
            }

            try
            {
                var regex = new System.Text.RegularExpressions.Regex(input, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                match = foods.FirstOrDefault(f => regex.IsMatch(f.Name));
                if (match != null)
                {
                    editNoteCB.SelectedValue = match.Id;
                }
            }
            catch (ArgumentException)
            {
                // Invalid regex pattern, ignore
            }
        }
    }
}
