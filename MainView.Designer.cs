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
            logFoodPage = new TabPage();
            historyPage = new TabPage();
            foodsPage = new TabPage();
            addFoodPage = new TabPage();
            tabControl1.SuspendLayout();
            statsPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(caloriePerDayLabel, 1, 5);
            tableLayoutPanel1.Controls.Add(daysLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(totalCalorieConsumedValue, 1, 2);
            tableLayoutPanel1.Controls.Add(totalCalorieConsumedLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(daysValue, 1, 4);
            tableLayoutPanel1.Controls.Add(caloriePerDayValue, 1, 6);
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
            totalCalorieConsumedLabel.Click += label1_Click;
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
            // logFoodPage
            // 
            logFoodPage.Location = new Point(4, 24);
            logFoodPage.Name = "logFoodPage";
            logFoodPage.Size = new Size(792, 422);
            logFoodPage.TabIndex = 4;
            logFoodPage.Text = "Log Food";
            logFoodPage.UseVisualStyleBackColor = true;
            // 
            // historyPage
            // 
            historyPage.Location = new Point(4, 24);
            historyPage.Name = "historyPage";
            historyPage.Size = new Size(792, 422);
            historyPage.TabIndex = 3;
            historyPage.Text = "History";
            historyPage.UseVisualStyleBackColor = true;
            // 
            // foodsPage
            // 
            foodsPage.Location = new Point(4, 24);
            foodsPage.Name = "foodsPage";
            foodsPage.Padding = new Padding(3);
            foodsPage.Size = new Size(792, 422);
            foodsPage.TabIndex = 1;
            foodsPage.Text = "Foods";
            foodsPage.UseVisualStyleBackColor = true;
            // 
            // addFoodPage
            // 
            addFoodPage.Location = new Point(4, 24);
            addFoodPage.Name = "addFoodPage";
            addFoodPage.Size = new Size(792, 422);
            addFoodPage.TabIndex = 2;
            addFoodPage.Text = "Add Food Item";
            addFoodPage.UseVisualStyleBackColor = true;
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
    }
}