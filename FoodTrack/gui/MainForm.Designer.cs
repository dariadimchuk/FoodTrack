﻿namespace FoodTrack
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.caloriesProgressBar = new System.Windows.Forms.ProgressBar();
            this.totalCaloriesProgressBar = new System.Windows.Forms.Label();
            this.BreakfastLabel = new System.Windows.Forms.Label();
            this.LunchLabel = new System.Windows.Forms.Label();
            this.DinnerLabel = new System.Windows.Forms.Label();
            this.BreakfastAmountLabel = new System.Windows.Forms.Label();
            this.LunchAmountLabel = new System.Windows.Forms.Label();
            this.DinnerAmountLabel = new System.Windows.Forms.Label();
            this.editBreakfastBtn = new System.Windows.Forms.Button();
            this.editLunchBtn = new System.Windows.Forms.Button();
            this.editDinnerBtn = new System.Windows.Forms.Button();
            this.CarbsLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.ProteinLabel = new System.Windows.Forms.Label();
            this.fatProgressBar = new System.Windows.Forms.ProgressBar();
            this.carbsProgressBar = new System.Windows.Forms.ProgressBar();
            this.proteinProgressBar = new System.Windows.Forms.ProgressBar();
            this.goalsBtn = new System.Windows.Forms.Button();
            this.calorieProgressBarValueLabel = new System.Windows.Forms.Label();
            this.proteinProgressBarValueLabel = new System.Windows.Forms.Label();
            this.fatProgressBarValueLabel = new System.Windows.Forms.Label();
            this.carbProgressBarValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 26);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(246, 34);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // caloriesProgressBar
            // 
            this.caloriesProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.caloriesProgressBar.Location = new System.Drawing.Point(12, 135);
            this.caloriesProgressBar.MarqueeAnimationSpeed = 0;
            this.caloriesProgressBar.Maximum = 10000;
            this.caloriesProgressBar.Name = "caloriesProgressBar";
            this.caloriesProgressBar.Size = new System.Drawing.Size(743, 53);
            this.caloriesProgressBar.TabIndex = 1;
            // 
            // totalCaloriesProgressBar
            // 
            this.totalCaloriesProgressBar.AutoSize = true;
            this.totalCaloriesProgressBar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaloriesProgressBar.Location = new System.Drawing.Point(272, 90);
            this.totalCaloriesProgressBar.Name = "totalCaloriesProgressBar";
            this.totalCaloriesProgressBar.Size = new System.Drawing.Size(227, 26);
            this.totalCaloriesProgressBar.TabIndex = 8;
            this.totalCaloriesProgressBar.Text = "Total Calories Today";
            // 
            // BreakfastLabel
            // 
            this.BreakfastLabel.AutoSize = true;
            this.BreakfastLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakfastLabel.Location = new System.Drawing.Point(48, 408);
            this.BreakfastLabel.Name = "BreakfastLabel";
            this.BreakfastLabel.Size = new System.Drawing.Size(111, 25);
            this.BreakfastLabel.TabIndex = 11;
            this.BreakfastLabel.Text = "Breakfast";
            // 
            // LunchLabel
            // 
            this.LunchLabel.AutoSize = true;
            this.LunchLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchLabel.Location = new System.Drawing.Point(291, 408);
            this.LunchLabel.Name = "LunchLabel";
            this.LunchLabel.Size = new System.Drawing.Size(75, 25);
            this.LunchLabel.TabIndex = 12;
            this.LunchLabel.Text = "Lunch";
            // 
            // DinnerLabel
            // 
            this.DinnerLabel.AutoSize = true;
            this.DinnerLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerLabel.Location = new System.Drawing.Point(566, 408);
            this.DinnerLabel.Name = "DinnerLabel";
            this.DinnerLabel.Size = new System.Drawing.Size(79, 25);
            this.DinnerLabel.TabIndex = 13;
            this.DinnerLabel.Text = "Dinner";
            this.DinnerLabel.Click += new System.EventHandler(this.DinnerLabel_Click);
            // 
            // BreakfastAmountLabel
            // 
            this.BreakfastAmountLabel.AutoSize = true;
            this.BreakfastAmountLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakfastAmountLabel.Location = new System.Drawing.Point(175, 408);
            this.BreakfastAmountLabel.Name = "BreakfastAmountLabel";
            this.BreakfastAmountLabel.Size = new System.Drawing.Size(24, 25);
            this.BreakfastAmountLabel.TabIndex = 14;
            this.BreakfastAmountLabel.Text = "0";
            // 
            // LunchAmountLabel
            // 
            this.LunchAmountLabel.AutoSize = true;
            this.LunchAmountLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchAmountLabel.Location = new System.Drawing.Point(417, 408);
            this.LunchAmountLabel.Name = "LunchAmountLabel";
            this.LunchAmountLabel.Size = new System.Drawing.Size(24, 25);
            this.LunchAmountLabel.TabIndex = 15;
            this.LunchAmountLabel.Text = "0";
            // 
            // DinnerAmountLabel
            // 
            this.DinnerAmountLabel.AutoSize = true;
            this.DinnerAmountLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerAmountLabel.Location = new System.Drawing.Point(692, 408);
            this.DinnerAmountLabel.Name = "DinnerAmountLabel";
            this.DinnerAmountLabel.Size = new System.Drawing.Size(24, 25);
            this.DinnerAmountLabel.TabIndex = 16;
            this.DinnerAmountLabel.Text = "0";
            // 
            // editBreakfastBtn
            // 
            this.editBreakfastBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBreakfastBtn.Location = new System.Drawing.Point(70, 456);
            this.editBreakfastBtn.Name = "editBreakfastBtn";
            this.editBreakfastBtn.Size = new System.Drawing.Size(129, 40);
            this.editBreakfastBtn.TabIndex = 17;
            this.editBreakfastBtn.Text = "Edit";
            this.editBreakfastBtn.UseVisualStyleBackColor = true;
            this.editBreakfastBtn.Click += new System.EventHandler(this.EditBreakfastBtn_Click);
            // 
            // editLunchBtn
            // 
            this.editLunchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLunchBtn.Location = new System.Drawing.Point(312, 456);
            this.editLunchBtn.Name = "editLunchBtn";
            this.editLunchBtn.Size = new System.Drawing.Size(129, 40);
            this.editLunchBtn.TabIndex = 18;
            this.editLunchBtn.Text = "Edit";
            this.editLunchBtn.UseVisualStyleBackColor = true;
            this.editLunchBtn.Click += new System.EventHandler(this.EditLunchBtn_Click);
            // 
            // editDinnerBtn
            // 
            this.editDinnerBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDinnerBtn.Location = new System.Drawing.Point(587, 456);
            this.editDinnerBtn.Name = "editDinnerBtn";
            this.editDinnerBtn.Size = new System.Drawing.Size(129, 40);
            this.editDinnerBtn.TabIndex = 19;
            this.editDinnerBtn.Text = "Edit";
            this.editDinnerBtn.UseVisualStyleBackColor = true;
            this.editDinnerBtn.Click += new System.EventHandler(this.EditDinnerBtn_Click);
            // 
            // CarbsLabel
            // 
            this.CarbsLabel.AutoSize = true;
            this.CarbsLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbsLabel.Location = new System.Drawing.Point(80, 209);
            this.CarbsLabel.Name = "CarbsLabel";
            this.CarbsLabel.Size = new System.Drawing.Size(76, 25);
            this.CarbsLabel.TabIndex = 25;
            this.CarbsLabel.Text = "Carbs";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.Location = new System.Drawing.Point(372, 206);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(46, 25);
            this.fatLabel.TabIndex = 24;
            this.fatLabel.Text = "Fat";
            // 
            // ProteinLabel
            // 
            this.ProteinLabel.AutoSize = true;
            this.ProteinLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinLabel.Location = new System.Drawing.Point(611, 211);
            this.ProteinLabel.Name = "ProteinLabel";
            this.ProteinLabel.Size = new System.Drawing.Size(76, 23);
            this.ProteinLabel.TabIndex = 23;
            this.ProteinLabel.Text = "Protein";
            // 
            // fatProgressBar
            // 
            this.fatProgressBar.Location = new System.Drawing.Point(280, 237);
            this.fatProgressBar.Maximum = 5000;
            this.fatProgressBar.Name = "fatProgressBar";
            this.fatProgressBar.Size = new System.Drawing.Size(219, 45);
            this.fatProgressBar.TabIndex = 22;
            // 
            // carbsProgressBar
            // 
            this.carbsProgressBar.Location = new System.Drawing.Point(12, 237);
            this.carbsProgressBar.Maximum = 5000;
            this.carbsProgressBar.Name = "carbsProgressBar";
            this.carbsProgressBar.Size = new System.Drawing.Size(219, 45);
            this.carbsProgressBar.TabIndex = 21;
            // 
            // proteinProgressBar
            // 
            this.proteinProgressBar.Location = new System.Drawing.Point(536, 237);
            this.proteinProgressBar.Maximum = 5000;
            this.proteinProgressBar.Name = "proteinProgressBar";
            this.proteinProgressBar.Size = new System.Drawing.Size(219, 45);
            this.proteinProgressBar.TabIndex = 20;
            // 
            // goalsBtn
            // 
            this.goalsBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalsBtn.Location = new System.Drawing.Point(597, 22);
            this.goalsBtn.Name = "goalsBtn";
            this.goalsBtn.Size = new System.Drawing.Size(158, 46);
            this.goalsBtn.TabIndex = 26;
            this.goalsBtn.Text = "Set Goals";
            this.goalsBtn.UseVisualStyleBackColor = true;
            this.goalsBtn.Click += new System.EventHandler(this.GoalsBtn_Click);
            // 
            // calorieProgressBarValueLabel
            // 
            this.calorieProgressBarValueLabel.AutoSize = true;
            this.calorieProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.calorieProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieProgressBarValueLabel.Location = new System.Drawing.Point(323, 147);
            this.calorieProgressBarValueLabel.Name = "calorieProgressBarValueLabel";
            this.calorieProgressBarValueLabel.Size = new System.Drawing.Size(106, 25);
            this.calorieProgressBarValueLabel.TabIndex = 27;
            this.calorieProgressBarValueLabel.Text = "xxx / yyy";
            // 
            // proteinProgressBarValueLabel
            // 
            this.proteinProgressBarValueLabel.AutoSize = true;
            this.proteinProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.proteinProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinProgressBarValueLabel.Location = new System.Drawing.Point(592, 247);
            this.proteinProgressBarValueLabel.Name = "proteinProgressBarValueLabel";
            this.proteinProgressBarValueLabel.Size = new System.Drawing.Size(106, 25);
            this.proteinProgressBarValueLabel.TabIndex = 28;
            this.proteinProgressBarValueLabel.Text = "xxx / yyy";
            // 
            // fatProgressBarValueLabel
            // 
            this.fatProgressBarValueLabel.AutoSize = true;
            this.fatProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.fatProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatProgressBarValueLabel.Location = new System.Drawing.Point(344, 247);
            this.fatProgressBarValueLabel.Name = "fatProgressBarValueLabel";
            this.fatProgressBarValueLabel.Size = new System.Drawing.Size(106, 25);
            this.fatProgressBarValueLabel.TabIndex = 29;
            this.fatProgressBarValueLabel.Text = "xxx / yyy";
            // 
            // carbProgressBarValueLabel
            // 
            this.carbProgressBarValueLabel.AutoSize = true;
            this.carbProgressBarValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.carbProgressBarValueLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbProgressBarValueLabel.Location = new System.Drawing.Point(62, 247);
            this.carbProgressBarValueLabel.Name = "carbProgressBarValueLabel";
            this.carbProgressBarValueLabel.Size = new System.Drawing.Size(106, 25);
            this.carbProgressBarValueLabel.TabIndex = 30;
            this.carbProgressBarValueLabel.Text = "xxx / yyy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add Food";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carbProgressBarValueLabel);
            this.Controls.Add(this.fatProgressBarValueLabel);
            this.Controls.Add(this.proteinProgressBarValueLabel);
            this.Controls.Add(this.calorieProgressBarValueLabel);
            this.Controls.Add(this.goalsBtn);
            this.Controls.Add(this.CarbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.ProteinLabel);
            this.Controls.Add(this.fatProgressBar);
            this.Controls.Add(this.carbsProgressBar);
            this.Controls.Add(this.proteinProgressBar);
            this.Controls.Add(this.editDinnerBtn);
            this.Controls.Add(this.editLunchBtn);
            this.Controls.Add(this.editBreakfastBtn);
            this.Controls.Add(this.DinnerAmountLabel);
            this.Controls.Add(this.LunchAmountLabel);
            this.Controls.Add(this.BreakfastAmountLabel);
            this.Controls.Add(this.DinnerLabel);
            this.Controls.Add(this.LunchLabel);
            this.Controls.Add(this.BreakfastLabel);
            this.Controls.Add(this.totalCaloriesProgressBar);
            this.Controls.Add(this.caloriesProgressBar);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Food Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ProgressBar caloriesProgressBar;
        private System.Windows.Forms.Label totalCaloriesProgressBar;
        private System.Windows.Forms.Label BreakfastLabel;
        private System.Windows.Forms.Label LunchLabel;
        private System.Windows.Forms.Label DinnerLabel;
        private System.Windows.Forms.Label BreakfastAmountLabel;
        private System.Windows.Forms.Label LunchAmountLabel;
        private System.Windows.Forms.Label DinnerAmountLabel;
        private System.Windows.Forms.Button editBreakfastBtn;
        private System.Windows.Forms.Button editLunchBtn;
        private System.Windows.Forms.Button editDinnerBtn;
        private System.Windows.Forms.Label CarbsLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label ProteinLabel;
        private System.Windows.Forms.ProgressBar fatProgressBar;
        private System.Windows.Forms.ProgressBar carbsProgressBar;
        private System.Windows.Forms.ProgressBar proteinProgressBar;
        private System.Windows.Forms.Button goalsBtn;
        private System.Windows.Forms.Label calorieProgressBarValueLabel;
        private System.Windows.Forms.Label proteinProgressBarValueLabel;
        private System.Windows.Forms.Label fatProgressBarValueLabel;
        private System.Windows.Forms.Label carbProgressBarValueLabel;
        private System.Windows.Forms.Label label1;
    }
}

