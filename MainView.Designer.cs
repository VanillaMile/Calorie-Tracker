namespace Calorie_Tracker
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTabControl = new TabControl();
            statsPage = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            caloriePerDayLabel = new Label();
            daysLabel = new Label();
            totalCalorieConsumedValue = new Label();
            totalCalorieConsumedLabel = new Label();
            daysValue = new Label();
            caloriePerDayValue = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            minDatePick = new DateTimePicker();
            maxDatePick = new DateTimePicker();
            refreshBtn = new Button();
            logFoodPage = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            FoodsComboBox = new ComboBox();
            TextLabel1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TextLabel2 = new Label();
            dateTimePickerLogFood = new DateTimePicker();
            label11 = new Label();
            gramsUpDown = new NumericUpDown();
            label12 = new Label();
            portionUpDown = new NumericUpDown();
            addFoodHistoryRecord = new Button();
            addedLabel = new Label();
            historyPage = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            historyListBox = new ListBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            historyMaxDate = new DateTimePicker();
            label13 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label14 = new Label();
            historyMinDate = new DateTimePicker();
            tableLayoutPanel8 = new TableLayoutPanel();
            historyNextPage = new Button();
            historyBackPage = new Button();
            historyEdit = new Button();
            historyDelete = new Button();
            foodsPage = new TabPage();
            tableLayoutPanel11 = new TableLayoutPanel();
            listBox2 = new ListBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            textBox8 = new TextBox();
            button5 = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            notesPage = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            button8 = new Button();
            button9 = new Button();
            button14 = new Button();
            button15 = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            dateTimePicker3 = new DateTimePicker();
            label15 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label16 = new Label();
            dateTimePicker4 = new DateTimePicker();
            listBox1 = new ListBox();
            addFoodPage = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            addFoodBtn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label8 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            errorAddFoodItemLabel = new Label();
            editHistory = new TabPage();
            tableLayoutPanel15 = new TableLayoutPanel();
            label17 = new Label();
            editHistoryEditBtn = new Button();
            tableLayoutPanel16 = new TableLayoutPanel();
            editHistoryRecordId = new TextBox();
            label18 = new Label();
            label21 = new Label();
            label22 = new Label();
            editHistoryPortion = new TextBox();
            label23 = new Label();
            editHistoryGrams = new TextBox();
            editHistoryDate = new DateTimePicker();
            editHistoryCombo = new ComboBox();
            label24 = new Label();
            editHistoryLabel = new Label();
            mainTabControl.SuspendLayout();
            statsPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            logFoodPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gramsUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)portionUpDown).BeginInit();
            historyPage.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            foodsPage.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            notesPage.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            addFoodPage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            editHistory.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(statsPage);
            mainTabControl.Controls.Add(logFoodPage);
            mainTabControl.Controls.Add(historyPage);
            mainTabControl.Controls.Add(foodsPage);
            mainTabControl.Controls.Add(notesPage);
            mainTabControl.Controls.Add(addFoodPage);
            mainTabControl.Controls.Add(editHistory);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 450);
            mainTabControl.TabIndex = 0;
            // 
            // statsPage
            // 
            statsPage.Controls.Add(tableLayoutPanel1);
            statsPage.Location = new Point(4, 24);
            statsPage.Name = "statsPage";
            statsPage.Padding = new Padding(3);
            statsPage.Size = new Size(792, 422);
            statsPage.TabIndex = 0;
            statsPage.Text = "Statistics";
            statsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(caloriePerDayLabel, 1, 5);
            tableLayoutPanel1.Controls.Add(daysLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(totalCalorieConsumedValue, 1, 2);
            tableLayoutPanel1.Controls.Add(totalCalorieConsumedLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(daysValue, 1, 4);
            tableLayoutPanel1.Controls.Add(caloriePerDayValue, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Controls.Add(refreshBtn, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(786, 416);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // caloriePerDayLabel
            // 
            caloriePerDayLabel.Anchor = AnchorStyles.None;
            caloriePerDayLabel.AutoSize = true;
            caloriePerDayLabel.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            caloriePerDayLabel.ForeColor = Color.Coral;
            caloriePerDayLabel.Location = new Point(306, 258);
            caloriePerDayLabel.Name = "caloriePerDayLabel";
            caloriePerDayLabel.Padding = new Padding(0, 10, 0, 0);
            caloriePerDayLabel.Size = new Size(173, 51);
            caloriePerDayLabel.TabIndex = 1;
            caloriePerDayLabel.Text = "Calorie/day";
            // 
            // daysLabel
            // 
            daysLabel.Anchor = AnchorStyles.None;
            daysLabel.AutoSize = true;
            daysLabel.FlatStyle = FlatStyle.Popup;
            daysLabel.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            daysLabel.ForeColor = Color.Coral;
            daysLabel.Location = new Point(351, 174);
            daysLabel.Name = "daysLabel";
            daysLabel.Padding = new Padding(0, 10, 0, 0);
            daysLabel.Size = new Size(83, 51);
            daysLabel.TabIndex = 0;
            daysLabel.Text = "Days";
            // 
            // totalCalorieConsumedValue
            // 
            totalCalorieConsumedValue.Anchor = AnchorStyles.None;
            totalCalorieConsumedValue.AutoSize = true;
            totalCalorieConsumedValue.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCalorieConsumedValue.ForeColor = Color.Lime;
            totalCalorieConsumedValue.Location = new Point(371, 125);
            totalCalorieConsumedValue.Name = "totalCalorieConsumedValue";
            totalCalorieConsumedValue.Size = new Size(43, 49);
            totalCalorieConsumedValue.TabIndex = 2;
            totalCalorieConsumedValue.Text = "0";
            // 
            // totalCalorieConsumedLabel
            // 
            totalCalorieConsumedLabel.Anchor = AnchorStyles.None;
            totalCalorieConsumedLabel.AutoSize = true;
            totalCalorieConsumedLabel.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            totalCalorieConsumedLabel.ForeColor = Color.Coral;
            totalCalorieConsumedLabel.Location = new Point(226, 74);
            totalCalorieConsumedLabel.Name = "totalCalorieConsumedLabel";
            totalCalorieConsumedLabel.Padding = new Padding(0, 10, 0, 0);
            totalCalorieConsumedLabel.Size = new Size(333, 51);
            totalCalorieConsumedLabel.TabIndex = 0;
            totalCalorieConsumedLabel.Text = "Total Calorie Consumed";
            // 
            // daysValue
            // 
            daysValue.Anchor = AnchorStyles.None;
            daysValue.AutoSize = true;
            daysValue.Font = new Font("Comic Sans MS", 18F);
            daysValue.ForeColor = Color.Chocolate;
            daysValue.Location = new Point(377, 225);
            daysValue.Name = "daysValue";
            daysValue.Size = new Size(30, 33);
            daysValue.TabIndex = 3;
            daysValue.Text = "0";
            // 
            // caloriePerDayValue
            // 
            caloriePerDayValue.Anchor = AnchorStyles.None;
            caloriePerDayValue.AutoSize = true;
            caloriePerDayValue.Font = new Font("Comic Sans MS", 18F);
            caloriePerDayValue.ForeColor = Color.Chocolate;
            caloriePerDayValue.Location = new Point(377, 309);
            caloriePerDayValue.Name = "caloriePerDayValue";
            caloriePerDayValue.Size = new Size(30, 33);
            caloriePerDayValue.TabIndex = 4;
            caloriePerDayValue.Text = "0";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.Controls.Add(label10, 1, 0);
            tableLayoutPanel5.Controls.Add(minDatePick, 0, 1);
            tableLayoutPanel5.Controls.Add(maxDatePick, 1, 1);
            tableLayoutPanel5.Location = new Point(160, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(465, 68);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(92, 19);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 0;
            label9.Text = "Data od";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Location = new Point(324, 19);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 1;
            label10.Text = "Data do";
            // 
            // minDatePick
            // 
            minDatePick.Anchor = AnchorStyles.Top;
            minDatePick.Location = new Point(8, 37);
            minDatePick.Name = "minDatePick";
            minDatePick.Size = new Size(215, 23);
            minDatePick.TabIndex = 2;
            // 
            // maxDatePick
            // 
            maxDatePick.Anchor = AnchorStyles.Top;
            maxDatePick.Location = new Point(243, 37);
            maxDatePick.Name = "maxDatePick";
            maxDatePick.Size = new Size(211, 23);
            maxDatePick.TabIndex = 3;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top;
            refreshBtn.Location = new Point(355, 345);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(75, 23);
            refreshBtn.TabIndex = 6;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_click;
            // 
            // logFoodPage
            // 
            logFoodPage.Controls.Add(tableLayoutPanel2);
            logFoodPage.Location = new Point(4, 24);
            logFoodPage.Name = "logFoodPage";
            logFoodPage.Size = new Size(792, 422);
            logFoodPage.TabIndex = 4;
            logFoodPage.Text = "Log Food";
            logFoodPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(FoodsComboBox, 1, 1);
            tableLayoutPanel2.Controls.Add(TextLabel1, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel2.Controls.Add(addFoodHistoryRecord, 2, 1);
            tableLayoutPanel2.Controls.Add(addedLabel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(792, 422);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // FoodsComboBox
            // 
            FoodsComboBox.Dock = DockStyle.Fill;
            FoodsComboBox.FormattingEnabled = true;
            FoodsComboBox.Location = new Point(82, 101);
            FoodsComboBox.Name = "FoodsComboBox";
            FoodsComboBox.Size = new Size(469, 23);
            FoodsComboBox.TabIndex = 10;
            // 
            // TextLabel1
            // 
            TextLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextLabel1.AutoSize = true;
            TextLabel1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextLabel1.Location = new Point(82, 51);
            TextLabel1.Name = "TextLabel1";
            TextLabel1.Size = new Size(250, 47);
            TextLabel1.TabIndex = 1;
            TextLabel1.Text = "Dodaj jedzenie";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(TextLabel2);
            flowLayoutPanel1.Controls.Add(dateTimePickerLogFood);
            flowLayoutPanel1.Controls.Add(label11);
            flowLayoutPanel1.Controls.Add(gramsUpDown);
            flowLayoutPanel1.Controls.Add(label12);
            flowLayoutPanel1.Controls.Add(portionUpDown);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(82, 130);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(469, 190);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // TextLabel2
            // 
            TextLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextLabel2.AutoSize = true;
            TextLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextLabel2.Location = new Point(3, 0);
            TextLabel2.Name = "TextLabel2";
            TextLabel2.Size = new Size(165, 25);
            TextLabel2.TabIndex = 2;
            TextLabel2.Text = "Data (Opcjonalne)";
            // 
            // dateTimePickerLogFood
            // 
            dateTimePickerLogFood.Location = new Point(3, 28);
            dateTimePickerLogFood.Name = "dateTimePickerLogFood";
            dateTimePickerLogFood.Size = new Size(200, 23);
            dateTimePickerLogFood.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 54);
            label11.Name = "label11";
            label11.Size = new Size(114, 15);
            label11.TabIndex = 6;
            label11.Text = "Gramy (Opcjonalne)";
            // 
            // gramsUpDown
            // 
            gramsUpDown.DecimalPlaces = 2;
            gramsUpDown.Location = new Point(3, 72);
            gramsUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            gramsUpDown.Name = "gramsUpDown";
            gramsUpDown.Size = new Size(120, 23);
            gramsUpDown.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 98);
            label12.Name = "label12";
            label12.Size = new Size(109, 15);
            label12.TabIndex = 7;
            label12.Text = "Porcje(Opcjonalne)";
            // 
            // portionUpDown
            // 
            portionUpDown.DecimalPlaces = 2;
            portionUpDown.Location = new Point(3, 116);
            portionUpDown.Name = "portionUpDown";
            portionUpDown.Size = new Size(120, 23);
            portionUpDown.TabIndex = 5;
            // 
            // addFoodHistoryRecord
            // 
            addFoodHistoryRecord.Dock = DockStyle.Fill;
            addFoodHistoryRecord.Location = new Point(557, 101);
            addFoodHistoryRecord.Name = "addFoodHistoryRecord";
            addFoodHistoryRecord.Size = new Size(152, 23);
            addFoodHistoryRecord.TabIndex = 4;
            addFoodHistoryRecord.Text = "Add";
            addFoodHistoryRecord.UseVisualStyleBackColor = true;
            addFoodHistoryRecord.Click += addFoodHistoryRecord_Click;
            // 
            // addedLabel
            // 
            addedLabel.Anchor = AnchorStyles.Bottom;
            addedLabel.AutoSize = true;
            addedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addedLabel.ForeColor = Color.Lime;
            addedLabel.Location = new Point(633, 77);
            addedLabel.Name = "addedLabel";
            addedLabel.Size = new Size(0, 21);
            addedLabel.TabIndex = 11;
            // 
            // historyPage
            // 
            historyPage.Controls.Add(tableLayoutPanel6);
            historyPage.Location = new Point(4, 24);
            historyPage.Name = "historyPage";
            historyPage.Size = new Size(792, 422);
            historyPage.TabIndex = 3;
            historyPage.Text = "History";
            historyPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(historyListBox, 1, 1);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.Size = new Size(792, 422);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // historyListBox
            // 
            historyListBox.Dock = DockStyle.Fill;
            historyListBox.FormattingEnabled = true;
            historyListBox.Location = new Point(3, 45);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(786, 331);
            historyListBox.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel7.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(786, 36);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(historyMaxDate);
            flowLayoutPanel2.Controls.Add(label13);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(396, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(387, 30);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // historyMaxDate
            // 
            historyMaxDate.Location = new Point(184, 3);
            historyMaxDate.Name = "historyMaxDate";
            historyMaxDate.Size = new Size(200, 23);
            historyMaxDate.TabIndex = 0;
            historyMaxDate.ValueChanged += historyMaxDate_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(142, 0);
            label13.Name = "label13";
            label13.Size = new Size(36, 25);
            label13.TabIndex = 1;
            label13.Text = "Do";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label14);
            flowLayoutPanel4.Controls.Add(historyMinDate);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(387, 30);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(37, 25);
            label14.TabIndex = 1;
            label14.Text = "Od";
            // 
            // historyMinDate
            // 
            historyMinDate.Location = new Point(46, 3);
            historyMinDate.Name = "historyMinDate";
            historyMinDate.Size = new Size(200, 23);
            historyMinDate.TabIndex = 0;
            historyMinDate.ValueChanged += historyMinDate_ValueChanged;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 6;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel8.Controls.Add(historyNextPage, 3, 0);
            tableLayoutPanel8.Controls.Add(historyBackPage, 2, 0);
            tableLayoutPanel8.Controls.Add(historyEdit, 5, 0);
            tableLayoutPanel8.Controls.Add(historyDelete, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 382);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(786, 37);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // historyNextPage
            // 
            historyNextPage.Location = new Point(394, 3);
            historyNextPage.Name = "historyNextPage";
            historyNextPage.Size = new Size(111, 31);
            historyNextPage.TabIndex = 1;
            historyNextPage.Text = "Następna";
            historyNextPage.UseVisualStyleBackColor = true;
            historyNextPage.Click += historyNextPage_Click;
            // 
            // historyBackPage
            // 
            historyBackPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            historyBackPage.Location = new Point(277, 3);
            historyBackPage.Name = "historyBackPage";
            historyBackPage.Size = new Size(111, 31);
            historyBackPage.TabIndex = 0;
            historyBackPage.Text = "Poprzednia";
            historyBackPage.UseVisualStyleBackColor = true;
            historyBackPage.Click += historyBackPage_Click;
            // 
            // historyEdit
            // 
            historyEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            historyEdit.Location = new Point(707, 3);
            historyEdit.Name = "historyEdit";
            historyEdit.Size = new Size(76, 31);
            historyEdit.TabIndex = 2;
            historyEdit.Text = "Edytuj";
            historyEdit.UseVisualStyleBackColor = true;
            historyEdit.Click += historyEdit_Click;
            // 
            // historyDelete
            // 
            historyDelete.BackColor = Color.Transparent;
            historyDelete.ForeColor = Color.Firebrick;
            historyDelete.Location = new Point(3, 3);
            historyDelete.Name = "historyDelete";
            historyDelete.Size = new Size(72, 31);
            historyDelete.TabIndex = 3;
            historyDelete.Text = "Usuń";
            historyDelete.UseVisualStyleBackColor = false;
            historyDelete.Click += historyDelete_Click;
            // 
            // foodsPage
            // 
            foodsPage.Controls.Add(tableLayoutPanel11);
            foodsPage.Location = new Point(4, 24);
            foodsPage.Name = "foodsPage";
            foodsPage.Padding = new Padding(3);
            foodsPage.Size = new Size(792, 422);
            foodsPage.TabIndex = 1;
            foodsPage.Text = "Foods";
            foodsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(listBox2, 1, 1);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 0, 2);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 3;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.Size = new Size(786, 416);
            tableLayoutPanel11.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(3, 44);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(780, 326);
            listBox2.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.Controls.Add(textBox8, 0, 0);
            tableLayoutPanel12.Controls.Add(button5, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(780, 35);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox8.Location = new Point(3, 9);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(384, 23);
            textBox8.TabIndex = 0;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(393, 9);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "Szukaj";
            button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 6;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.Controls.Add(button1, 3, 0);
            tableLayoutPanel13.Controls.Add(button2, 2, 0);
            tableLayoutPanel13.Controls.Add(button3, 5, 0);
            tableLayoutPanel13.Controls.Add(button4, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 376);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(780, 37);
            tableLayoutPanel13.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(393, 3);
            button1.Name = "button1";
            button1.Size = new Size(111, 31);
            button1.TabIndex = 1;
            button1.Text = "Następna";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(276, 3);
            button2.Name = "button2";
            button2.Size = new Size(111, 31);
            button2.TabIndex = 0;
            button2.Text = "Poprzednia";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(705, 3);
            button3.Name = "button3";
            button3.Size = new Size(72, 31);
            button3.TabIndex = 2;
            button3.Text = "Edytuj";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.Firebrick;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(72, 31);
            button4.TabIndex = 3;
            button4.Text = "Usuń";
            button4.UseVisualStyleBackColor = false;
            // 
            // notesPage
            // 
            notesPage.Controls.Add(tableLayoutPanel9);
            notesPage.Location = new Point(4, 24);
            notesPage.Name = "notesPage";
            notesPage.Size = new Size(792, 422);
            notesPage.TabIndex = 5;
            notesPage.Text = "Notes";
            notesPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel14, 0, 2);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel9.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.Size = new Size(792, 422);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 6;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel14.Controls.Add(button8, 3, 0);
            tableLayoutPanel14.Controls.Add(button9, 2, 0);
            tableLayoutPanel14.Controls.Add(button14, 5, 0);
            tableLayoutPanel14.Controls.Add(button15, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 382);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(786, 37);
            tableLayoutPanel14.TabIndex = 9;
            // 
            // button8
            // 
            button8.Location = new Point(394, 3);
            button8.Name = "button8";
            button8.Size = new Size(111, 31);
            button8.TabIndex = 1;
            button8.Text = "Następna";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button9.Location = new Point(277, 3);
            button9.Name = "button9";
            button9.Size = new Size(111, 31);
            button9.TabIndex = 0;
            button9.Text = "Poprzednia";
            button9.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button14.Location = new Point(707, 3);
            button14.Name = "button14";
            button14.Size = new Size(76, 31);
            button14.TabIndex = 2;
            button14.Text = "Edytuj";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.BackColor = Color.Transparent;
            button15.ForeColor = Color.Firebrick;
            button15.Location = new Point(3, 3);
            button15.Name = "button15";
            button15.Size = new Size(72, 31);
            button15.TabIndex = 3;
            button15.Text = "Usuń";
            button15.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(flowLayoutPanel3, 1, 0);
            tableLayoutPanel10.Controls.Add(flowLayoutPanel5, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(786, 36);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(dateTimePicker3);
            flowLayoutPanel3.Controls.Add(label15);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(396, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(387, 30);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(184, 3);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(142, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 25);
            label15.TabIndex = 1;
            label15.Text = "Do";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label16);
            flowLayoutPanel5.Controls.Add(dateTimePicker4);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(387, 30);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(37, 25);
            label16.TabIndex = 1;
            label16.Text = "Od";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(46, 3);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(786, 331);
            listBox1.TabIndex = 10;
            // 
            // addFoodPage
            // 
            addFoodPage.Controls.Add(tableLayoutPanel3);
            addFoodPage.Location = new Point(4, 24);
            addFoodPage.Name = "addFoodPage";
            addFoodPage.Size = new Size(792, 422);
            addFoodPage.TabIndex = 2;
            addFoodPage.Text = "Add Food Item";
            addFoodPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(label7, 1, 0);
            tableLayoutPanel3.Controls.Add(addFoodBtn, 1, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel3.Controls.Add(errorAddFoodItemLabel, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(792, 422);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 0);
            label7.Name = "label7";
            label7.Size = new Size(317, 42);
            label7.TabIndex = 4;
            label7.Text = "Dodaj nowe jedzenie";
            // 
            // addFoodBtn
            // 
            addFoodBtn.Anchor = AnchorStyles.Top;
            addFoodBtn.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addFoodBtn.Location = new Point(101, 340);
            addFoodBtn.Name = "addFoodBtn";
            addFoodBtn.Size = new Size(589, 63);
            addFoodBtn.TabIndex = 5;
            addFoodBtn.Text = "Dodaj";
            addFoodBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(label8, 1, 6);
            tableLayoutPanel4.Controls.Add(textBox7, 0, 6);
            tableLayoutPanel4.Controls.Add(label6, 1, 5);
            tableLayoutPanel4.Controls.Add(textBox6, 0, 5);
            tableLayoutPanel4.Controls.Add(label5, 1, 4);
            tableLayoutPanel4.Controls.Add(textBox5, 0, 4);
            tableLayoutPanel4.Controls.Add(label4, 1, 3);
            tableLayoutPanel4.Controls.Add(textBox4, 0, 3);
            tableLayoutPanel4.Controls.Add(label3, 1, 2);
            tableLayoutPanel4.Controls.Add(textBox3, 0, 2);
            tableLayoutPanel4.Controls.Add(label2, 1, 1);
            tableLayoutPanel4.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(82, 45);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(627, 247);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(458, 174);
            label8.Name = "label8";
            label8.Size = new Size(130, 25);
            label8.TabIndex = 13;
            label8.Text = "Gram w porcji";
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(3, 177);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(449, 23);
            textBox7.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(458, 145);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 11;
            label6.Text = "Kofeina/100Gram";
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(3, 148);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(449, 23);
            textBox6.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(458, 116);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 9;
            label5.Text = "Proteiny/100Gram";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(3, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(449, 23);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(458, 87);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 7;
            label4.Text = "Sole/100Gram";
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(3, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(449, 23);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(458, 58);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 5;
            label3.Text = "Tluszcze/100Gram";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(449, 23);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 29);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 3;
            label2.Text = "Calorie/100Gram";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(449, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Nazwa";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 23);
            textBox1.TabIndex = 1;
            // 
            // errorAddFoodItemLabel
            // 
            errorAddFoodItemLabel.Anchor = AnchorStyles.None;
            errorAddFoodItemLabel.AutoSize = true;
            errorAddFoodItemLabel.Location = new Point(345, 308);
            errorAddFoodItemLabel.Name = "errorAddFoodItemLabel";
            errorAddFoodItemLabel.Size = new Size(101, 15);
            errorAddFoodItemLabel.TabIndex = 7;
            errorAddFoodItemLabel.Text = "TEMP: Informacja";
            // 
            // editHistory
            // 
            editHistory.Controls.Add(tableLayoutPanel15);
            editHistory.Location = new Point(4, 24);
            editHistory.Name = "editHistory";
            editHistory.Size = new Size(792, 422);
            editHistory.TabIndex = 6;
            editHistory.Text = "Edit History Record";
            editHistory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 3;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel15.Controls.Add(label17, 1, 0);
            tableLayoutPanel15.Controls.Add(editHistoryEditBtn, 1, 3);
            tableLayoutPanel15.Controls.Add(tableLayoutPanel16, 1, 1);
            tableLayoutPanel15.Controls.Add(editHistoryLabel, 1, 2);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(0, 0);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 4;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel15.Size = new Size(792, 422);
            tableLayoutPanel15.TabIndex = 1;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(82, 0);
            label17.Name = "label17";
            label17.Size = new Size(209, 42);
            label17.TabIndex = 4;
            label17.Text = "Edytuj rekord";
            // 
            // editHistoryEditBtn
            // 
            editHistoryEditBtn.Anchor = AnchorStyles.Top;
            editHistoryEditBtn.Enabled = false;
            editHistoryEditBtn.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editHistoryEditBtn.Location = new Point(101, 340);
            editHistoryEditBtn.Name = "editHistoryEditBtn";
            editHistoryEditBtn.Size = new Size(589, 63);
            editHistoryEditBtn.TabIndex = 5;
            editHistoryEditBtn.Text = "Brak rekordu do edycji";
            editHistoryEditBtn.UseVisualStyleBackColor = true;
            editHistoryEditBtn.Click += editHistoryEditBtn_Click;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel16.Controls.Add(editHistoryRecordId, 0, 4);
            tableLayoutPanel16.Controls.Add(label18, 1, 4);
            tableLayoutPanel16.Controls.Add(label21, 1, 3);
            tableLayoutPanel16.Controls.Add(label22, 1, 2);
            tableLayoutPanel16.Controls.Add(editHistoryPortion, 0, 2);
            tableLayoutPanel16.Controls.Add(label23, 1, 1);
            tableLayoutPanel16.Controls.Add(editHistoryGrams, 0, 1);
            tableLayoutPanel16.Controls.Add(editHistoryDate, 0, 0);
            tableLayoutPanel16.Controls.Add(editHistoryCombo, 0, 3);
            tableLayoutPanel16.Controls.Add(label24, 1, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(82, 45);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 7;
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.Size = new Size(627, 247);
            tableLayoutPanel16.TabIndex = 6;
            // 
            // editHistoryRecordId
            // 
            editHistoryRecordId.Dock = DockStyle.Fill;
            editHistoryRecordId.Enabled = false;
            editHistoryRecordId.Location = new Point(3, 119);
            editHistoryRecordId.Name = "editHistoryRecordId";
            editHistoryRecordId.Size = new Size(530, 23);
            editHistoryRecordId.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(539, 116);
            label18.Name = "label18";
            label18.Size = new Size(70, 25);
            label18.TabIndex = 11;
            label18.Text = "Rekord";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(539, 87);
            label21.Name = "label21";
            label21.Size = new Size(85, 25);
            label21.TabIndex = 7;
            label21.Text = "Jedzenie";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(539, 58);
            label22.Name = "label22";
            label22.Size = new Size(64, 25);
            label22.TabIndex = 5;
            label22.Text = "Porcje";
            // 
            // editHistoryPortion
            // 
            editHistoryPortion.Dock = DockStyle.Fill;
            editHistoryPortion.Location = new Point(3, 61);
            editHistoryPortion.Name = "editHistoryPortion";
            editHistoryPortion.Size = new Size(530, 23);
            editHistoryPortion.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(539, 29);
            label23.Name = "label23";
            label23.Size = new Size(67, 25);
            label23.TabIndex = 3;
            label23.Text = "Gramy";
            // 
            // editHistoryGrams
            // 
            editHistoryGrams.Dock = DockStyle.Fill;
            editHistoryGrams.Location = new Point(3, 32);
            editHistoryGrams.Name = "editHistoryGrams";
            editHistoryGrams.Size = new Size(530, 23);
            editHistoryGrams.TabIndex = 2;
            // 
            // editHistoryDate
            // 
            editHistoryDate.Anchor = AnchorStyles.Right;
            editHistoryDate.Location = new Point(333, 3);
            editHistoryDate.Name = "editHistoryDate";
            editHistoryDate.Size = new Size(200, 23);
            editHistoryDate.TabIndex = 8;
            // 
            // editHistoryCombo
            // 
            editHistoryCombo.Dock = DockStyle.Fill;
            editHistoryCombo.FormattingEnabled = true;
            editHistoryCombo.Location = new Point(3, 90);
            editHistoryCombo.Name = "editHistoryCombo";
            editHistoryCombo.Size = new Size(530, 23);
            editHistoryCombo.TabIndex = 9;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(539, 0);
            label24.Name = "label24";
            label24.Size = new Size(51, 25);
            label24.TabIndex = 0;
            label24.Text = "Data";
            // 
            // editHistoryLabel
            // 
            editHistoryLabel.Anchor = AnchorStyles.None;
            editHistoryLabel.AutoSize = true;
            editHistoryLabel.Location = new Point(345, 308);
            editHistoryLabel.Name = "editHistoryLabel";
            editHistoryLabel.Size = new Size(101, 15);
            editHistoryLabel.TabIndex = 7;
            editHistoryLabel.Text = "TEMP: Informacja";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTabControl);
            Name = "MainView";
            Text = "MainView";
            mainTabControl.ResumeLayout(false);
            statsPage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            logFoodPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gramsUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)portionUpDown).EndInit();
            historyPage.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            foodsPage.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            notesPage.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            addFoodPage.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            editHistory.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage foodsPage;
        private TabPage logFoodPage;
        private TabPage historyPage;
        private TabPage addFoodPage;
        private TabPage statsPage;
        private Label daysLabel;
        private Label totalCalorieConsumedLabel;
        private Label totalCalorieConsumedValue;
        private Label caloriePerDayLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label daysValue;
        private Label caloriePerDayValue;
        private TableLayoutPanel tableLayoutPanel2;
        private Label TextLabel1;
        private Label TextLabel2;
        private DateTimePicker dateTimePickerLogFood;
        private Button addFoodHistoryRecord;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox FoodsComboBox;
        private ListBox historyListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private Button addFoodBtn;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox7;
        private Label errorAddFoodItemLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label9;
        private Label label10;
        private DateTimePicker minDatePick;
        private DateTimePicker maxDatePick;
        private Button refreshBtn;
        private Label label11;
        private NumericUpDown gramsUpDown;
        private Label label12;
        private NumericUpDown portionUpDown;
        private Label addedLabel;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel2;
        private DateTimePicker historyMaxDate;
        private FlowLayoutPanel flowLayoutPanel4;
        private DateTimePicker historyMinDate;
        private Label label13;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel8;
        private Button historyNextPage;
        private Button historyBackPage;
        private TabPage notesPage;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel3;
        private DateTimePicker dateTimePicker3;
        private Label label15;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label16;
        private DateTimePicker dateTimePicker4;
        private Button historyEdit;
        private Button historyDelete;
        private TableLayoutPanel tableLayoutPanel14;
        private Button button8;
        private Button button9;
        private Button button14;
        private Button button15;
        private ListBox listBox1;
        private TabPage editHistory;
        private TableLayoutPanel tableLayoutPanel11;
        private ListBox listBox2;
        private TableLayoutPanel tableLayoutPanel12;
        private TextBox textBox8;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel13;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label17;
        private Button editHistoryEditBtn;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label21;
        private Label label22;
        private TextBox editHistoryPortion;
        private Label label23;
        private TextBox editHistoryGrams;
        private Label label24;
        private Label editHistoryLabel;
        private DateTimePicker editHistoryDate;
        private ComboBox editHistoryCombo;
        private Label label18;
        private TextBox editHistoryRecordId;
    }
}