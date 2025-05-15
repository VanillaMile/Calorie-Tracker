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
            tabControl1 = new TabControl();
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            logFoodPage = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            FoodsComboBox = new ComboBox();
            TextLabel1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TextLabel2 = new Label();
            dateTimePickerLogFood = new DateTimePicker();
            button1 = new Button();
            historyPage = new TabPage();
            historyListBox = new ListBox();
            foodsPage = new TabPage();
            foodsListBox = new ListBox();
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
            tabControl1.SuspendLayout();
            statsPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            logFoodPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            historyPage.SuspendLayout();
            foodsPage.SuspendLayout();
            addFoodPage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(statsPage);
            tabControl1.Controls.Add(logFoodPage);
            tabControl1.Controls.Add(historyPage);
            tabControl1.Controls.Add(foodsPage);
            tabControl1.Controls.Add(addFoodPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
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
            tableLayoutPanel1.Controls.Add(button2, 1, 7);
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
            tableLayoutPanel5.Controls.Add(dateTimePicker1, 0, 1);
            tableLayoutPanel5.Controls.Add(dateTimePicker2, 1, 1);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Location = new Point(8, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top;
            dateTimePicker2.Location = new Point(243, 37);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(211, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(355, 345);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
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
            tableLayoutPanel2.Controls.Add(button1, 2, 1);
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
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(557, 101);
            button1.Name = "button1";
            button1.Size = new Size(152, 23);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // historyPage
            // 
            historyPage.Controls.Add(historyListBox);
            historyPage.Location = new Point(4, 24);
            historyPage.Name = "historyPage";
            historyPage.Size = new Size(792, 422);
            historyPage.TabIndex = 3;
            historyPage.Text = "History";
            historyPage.UseVisualStyleBackColor = true;
            // 
            // historyListBox
            // 
            historyListBox.Dock = DockStyle.Fill;
            historyListBox.FormattingEnabled = true;
            historyListBox.Location = new Point(0, 0);
            historyListBox.Name = "historyListBox";
            historyListBox.Size = new Size(792, 422);
            historyListBox.TabIndex = 0;
            // 
            // foodsPage
            // 
            foodsPage.Controls.Add(foodsListBox);
            foodsPage.Location = new Point(4, 24);
            foodsPage.Name = "foodsPage";
            foodsPage.Padding = new Padding(3);
            foodsPage.Size = new Size(792, 422);
            foodsPage.TabIndex = 1;
            foodsPage.Text = "Foods";
            foodsPage.UseVisualStyleBackColor = true;
            // 
            // foodsListBox
            // 
            foodsListBox.Dock = DockStyle.Fill;
            foodsListBox.FormattingEnabled = true;
            foodsListBox.Location = new Point(3, 3);
            foodsListBox.Name = "foodsListBox";
            foodsListBox.Size = new Size(786, 416);
            foodsListBox.TabIndex = 0;
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
            addFoodBtn.Dock = DockStyle.Fill;
            addFoodBtn.Location = new Point(82, 340);
            addFoodBtn.Name = "addFoodBtn";
            addFoodBtn.Size = new Size(627, 79);
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
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainView";
            Text = "MainView";
            tabControl1.ResumeLayout(false);
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
            historyPage.ResumeLayout(false);
            foodsPage.ResumeLayout(false);
            addFoodPage.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox FoodsComboBox;
        private ListBox historyListBox;
        private ListBox foodsListBox;
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
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
    }
}