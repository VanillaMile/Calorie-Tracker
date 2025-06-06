namespace Calorie_Tracker
{
    partial class showFoodInfo
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
            tableLayoutPanel1 = new TableLayoutPanel();
            calorieLBL = new Label();
            nameLBL = new Label();
            gramsLBL = new Label();
            caffeineLBL = new Label();
            proteinLBL = new Label();
            fatsLBL = new Label();
            saltsLBL = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(calorieLBL, 0, 2);
            tableLayoutPanel1.Controls.Add(nameLBL, 0, 1);
            tableLayoutPanel1.Controls.Add(gramsLBL, 0, 7);
            tableLayoutPanel1.Controls.Add(caffeineLBL, 0, 6);
            tableLayoutPanel1.Controls.Add(proteinLBL, 0, 5);
            tableLayoutPanel1.Controls.Add(fatsLBL, 0, 3);
            tableLayoutPanel1.Controls.Add(saltsLBL, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.66667F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // calorieLBL
            // 
            calorieLBL.Anchor = AnchorStyles.None;
            calorieLBL.AutoSize = true;
            calorieLBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calorieLBL.Location = new Point(370, 138);
            calorieLBL.Name = "calorieLBL";
            calorieLBL.Size = new Size(59, 21);
            calorieLBL.TabIndex = 3;
            calorieLBL.Text = "Calorie";
            // 
            // nameLBL
            // 
            nameLBL.Anchor = AnchorStyles.None;
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLBL.Location = new Point(347, 93);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(105, 45);
            nameLBL.TabIndex = 1;
            nameLBL.Text = "Name";
            // 
            // gramsLBL
            // 
            gramsLBL.Anchor = AnchorStyles.None;
            gramsLBL.AutoSize = true;
            gramsLBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gramsLBL.Location = new Point(336, 243);
            gramsLBL.Name = "gramsLBL";
            gramsLBL.Size = new Size(128, 21);
            gramsLBL.TabIndex = 7;
            gramsLBL.Text = "Grams in portion";
            // 
            // caffeineLBL
            // 
            caffeineLBL.Anchor = AnchorStyles.None;
            caffeineLBL.AutoSize = true;
            caffeineLBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caffeineLBL.Location = new Point(366, 222);
            caffeineLBL.Name = "caffeineLBL";
            caffeineLBL.Size = new Size(67, 21);
            caffeineLBL.TabIndex = 6;
            caffeineLBL.Text = "Caffeine";
            // 
            // proteinLBL
            // 
            proteinLBL.Anchor = AnchorStyles.None;
            proteinLBL.AutoSize = true;
            proteinLBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proteinLBL.Location = new Point(370, 201);
            proteinLBL.Name = "proteinLBL";
            proteinLBL.Size = new Size(60, 21);
            proteinLBL.TabIndex = 5;
            proteinLBL.Text = "Protein";
            // 
            // fatsLBL
            // 
            fatsLBL.Anchor = AnchorStyles.None;
            fatsLBL.AutoSize = true;
            fatsLBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fatsLBL.Location = new Point(381, 159);
            fatsLBL.Name = "fatsLBL";
            fatsLBL.Size = new Size(37, 21);
            fatsLBL.TabIndex = 4;
            fatsLBL.Text = "Fats";
            // 
            // saltsLBL
            // 
            saltsLBL.Anchor = AnchorStyles.None;
            saltsLBL.AutoSize = true;
            saltsLBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saltsLBL.Location = new Point(379, 180);
            saltsLBL.Name = "saltsLBL";
            saltsLBL.Size = new Size(41, 21);
            saltsLBL.TabIndex = 8;
            saltsLBL.Text = "salts";
            saltsLBL.Click += saltsLBL_Click;
            // 
            // showFoodInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "showFoodInfo";
            Text = "showFoodInfo";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label caffeineLBL;
        private Label proteinLBL;
        private Label fatsLBL;
        private Label calorieLBL;
        private Label nameLBL;
        private Label gramsLBL;
        private Label saltsLBL;
    }
}