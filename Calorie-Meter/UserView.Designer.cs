namespace Calorie_Meter
{
    partial class UserView
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
            this.btnFoodReport = new System.Windows.Forms.Button();
            this.btnReportEndOfDay = new System.Windows.Forms.Button();
            this.dtpRepastTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgvSnacks = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDinner = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLunch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBreakfast = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUserInformation = new System.Windows.Forms.GroupBox();
            this.lblTotalProtein = new System.Windows.Forms.Label();
            this.lblTotalCarbohydrate = new System.Windows.Forms.Label();
            this.lblTotalFat = new System.Windows.Forms.Label();
            this.lblTotalCalorie = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnComparisons = new System.Windows.Forms.Button();
            this.pboKullaniciYiyecekForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).BeginInit();
            this.grpUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboKullaniciYiyecekForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFoodReport
            // 
            this.btnFoodReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFoodReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoodReport.ForeColor = System.Drawing.Color.White;
            this.btnFoodReport.Location = new System.Drawing.Point(630, 521);
            this.btnFoodReport.Name = "btnFoodReport";
            this.btnFoodReport.Size = new System.Drawing.Size(132, 60);
            this.btnFoodReport.TabIndex = 32;
            this.btnFoodReport.Text = "Food Report";
            this.btnFoodReport.UseVisualStyleBackColor = false;
            this.btnFoodReport.Click += new System.EventHandler(this.btnFoodReport_Click);
            // 
            // btnReportEndOfDay
            // 
            this.btnReportEndOfDay.BackColor = System.Drawing.Color.Firebrick;
            this.btnReportEndOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReportEndOfDay.ForeColor = System.Drawing.Color.White;
            this.btnReportEndOfDay.Location = new System.Drawing.Point(295, 521);
            this.btnReportEndOfDay.Name = "btnReportEndOfDay";
            this.btnReportEndOfDay.Size = new System.Drawing.Size(132, 60);
            this.btnReportEndOfDay.TabIndex = 31;
            this.btnReportEndOfDay.Text = "Report End Of The Day";
            this.btnReportEndOfDay.UseVisualStyleBackColor = false;
            this.btnReportEndOfDay.Click += new System.EventHandler(this.btnReportEndOfDay_Click);
            // 
            // dtpRepastTime
            // 
            this.dtpRepastTime.Location = new System.Drawing.Point(9, 392);
            this.dtpRepastTime.Name = "dtpRepastTime";
            this.dtpRepastTime.Size = new System.Drawing.Size(269, 20);
            this.dtpRepastTime.TabIndex = 30;
            this.dtpRepastTime.ValueChanged += new System.EventHandler(this.dtpRepastTime_ValueChanged);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.Location = new System.Drawing.Point(9, 425);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(269, 80);
            this.btnAddFood.TabIndex = 29;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dgvSnacks
            // 
            this.dgvSnacks.AllowUserToAddRows = false;
            this.dgvSnacks.AllowUserToDeleteRows = false;
            this.dgvSnacks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSnacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSnacks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSnacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSnacks.Location = new System.Drawing.Point(295, 416);
            this.dgvSnacks.MultiSelect = false;
            this.dgvSnacks.Name = "dgvSnacks";
            this.dgvSnacks.ReadOnly = true;
            this.dgvSnacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSnacks.Size = new System.Drawing.Size(777, 99);
            this.dgvSnacks.TabIndex = 28;
            this.dgvSnacks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSnacks_KeyDown);
            this.dgvSnacks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSnacks_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Snacks (Nutritive values are given per 100 grams)";
            // 
            // dgvDinner
            // 
            this.dgvDinner.AllowUserToAddRows = false;
            this.dgvDinner.AllowUserToDeleteRows = false;
            this.dgvDinner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDinner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDinner.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinner.Location = new System.Drawing.Point(295, 285);
            this.dgvDinner.MultiSelect = false;
            this.dgvDinner.Name = "dgvDinner";
            this.dgvDinner.ReadOnly = true;
            this.dgvDinner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDinner.Size = new System.Drawing.Size(777, 99);
            this.dgvDinner.TabIndex = 26;
            this.dgvDinner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDinner_KeyDown);
            this.dgvDinner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDinner_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(290, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Dinner (Nutritive values are given per 100 grams)";
            // 
            // dgvLunch
            // 
            this.dgvLunch.AllowUserToAddRows = false;
            this.dgvLunch.AllowUserToDeleteRows = false;
            this.dgvLunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLunch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLunch.Location = new System.Drawing.Point(295, 155);
            this.dgvLunch.MultiSelect = false;
            this.dgvLunch.Name = "dgvLunch";
            this.dgvLunch.ReadOnly = true;
            this.dgvLunch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLunch.Size = new System.Drawing.Size(777, 99);
            this.dgvLunch.TabIndex = 24;
            this.dgvLunch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLunch_KeyDown);
            this.dgvLunch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLunch_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(290, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lunch (Nutritive values are given per 100 grams)";
            // 
            // dgvBreakfast
            // 
            this.dgvBreakfast.AllowUserToAddRows = false;
            this.dgvBreakfast.AllowUserToDeleteRows = false;
            this.dgvBreakfast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBreakfast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBreakfast.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBreakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreakfast.Location = new System.Drawing.Point(295, 24);
            this.dgvBreakfast.MultiSelect = false;
            this.dgvBreakfast.Name = "dgvBreakfast";
            this.dgvBreakfast.ReadOnly = true;
            this.dgvBreakfast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBreakfast.Size = new System.Drawing.Size(777, 99);
            this.dgvBreakfast.TabIndex = 22;
            this.dgvBreakfast.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBreakfast_KeyDown);
            this.dgvBreakfast.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBreakfast_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(290, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Breakfast (Nutritive values are given per 100 grams)";
            // 
            // grpUserInformation
            // 
            this.grpUserInformation.Controls.Add(this.lblTotalProtein);
            this.grpUserInformation.Controls.Add(this.lblTotalCarbohydrate);
            this.grpUserInformation.Controls.Add(this.lblTotalFat);
            this.grpUserInformation.Controls.Add(this.lblTotalCalorie);
            this.grpUserInformation.Controls.Add(this.lblName);
            this.grpUserInformation.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUserInformation.Location = new System.Drawing.Point(9, 132);
            this.grpUserInformation.Name = "grpUserInformation";
            this.grpUserInformation.Size = new System.Drawing.Size(269, 252);
            this.grpUserInformation.TabIndex = 19;
            this.grpUserInformation.TabStop = false;
            this.grpUserInformation.Text = "User Informations";
            // 
            // lblTotalProtein
            // 
            this.lblTotalProtein.AutoSize = true;
            this.lblTotalProtein.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalProtein.Location = new System.Drawing.Point(6, 130);
            this.lblTotalProtein.Name = "lblTotalProtein";
            this.lblTotalProtein.Size = new System.Drawing.Size(102, 23);
            this.lblTotalProtein.TabIndex = 4;
            this.lblTotalProtein.Text = "Total Protein:";
            // 
            // lblTotalCarbohydrate
            // 
            this.lblTotalCarbohydrate.AutoSize = true;
            this.lblTotalCarbohydrate.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCarbohydrate.Location = new System.Drawing.Point(7, 165);
            this.lblTotalCarbohydrate.Name = "lblTotalCarbohydrate";
            this.lblTotalCarbohydrate.Size = new System.Drawing.Size(145, 23);
            this.lblTotalCarbohydrate.TabIndex = 3;
            this.lblTotalCarbohydrate.Text = "Total Carbohydrate:";
            // 
            // lblTotalFat
            // 
            this.lblTotalFat.AutoSize = true;
            this.lblTotalFat.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalFat.Location = new System.Drawing.Point(6, 96);
            this.lblTotalFat.Name = "lblTotalFat";
            this.lblTotalFat.Size = new System.Drawing.Size(75, 23);
            this.lblTotalFat.TabIndex = 2;
            this.lblTotalFat.Text = "Total Fat:";
            // 
            // lblTotalCalorie
            // 
            this.lblTotalCalorie.AutoSize = true;
            this.lblTotalCalorie.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCalorie.Location = new System.Drawing.Point(6, 65);
            this.lblTotalCalorie.Name = "lblTotalCalorie";
            this.lblTotalCalorie.Size = new System.Drawing.Size(104, 23);
            this.lblTotalCalorie.TabIndex = 1;
            this.lblTotalCalorie.Text = "Total Calorie :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(7, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnComparisons
            // 
            this.btnComparisons.BackColor = System.Drawing.Color.DarkViolet;
            this.btnComparisons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComparisons.ForeColor = System.Drawing.Color.White;
            this.btnComparisons.Location = new System.Drawing.Point(940, 521);
            this.btnComparisons.Name = "btnComparisons";
            this.btnComparisons.Size = new System.Drawing.Size(132, 60);
            this.btnComparisons.TabIndex = 33;
            this.btnComparisons.Text = "Camparison Reports";
            this.btnComparisons.UseVisualStyleBackColor = false;
            this.btnComparisons.Click += new System.EventHandler(this.btnComparisons_Click);
            // 
            // pboKullaniciYiyecekForm
            // 
            this.pboKullaniciYiyecekForm.Image = global::Calorie_Meter.Properties.Resources.diet__3_;
            this.pboKullaniciYiyecekForm.Location = new System.Drawing.Point(9, 5);
            this.pboKullaniciYiyecekForm.Name = "pboKullaniciYiyecekForm";
            this.pboKullaniciYiyecekForm.Size = new System.Drawing.Size(269, 128);
            this.pboKullaniciYiyecekForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboKullaniciYiyecekForm.TabIndex = 20;
            this.pboKullaniciYiyecekForm.TabStop = false;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1117, 590);
            this.Controls.Add(this.btnComparisons);
            this.Controls.Add(this.btnFoodReport);
            this.Controls.Add(this.btnReportEndOfDay);
            this.Controls.Add(this.dtpRepastTime);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.dgvSnacks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBreakfast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboKullaniciYiyecekForm);
            this.Controls.Add(this.grpUserInformation);
            this.Name = "UserView";
            this.Text = "User View";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).EndInit();
            this.grpUserInformation.ResumeLayout(false);
            this.grpUserInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboKullaniciYiyecekForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFoodReport;
        private System.Windows.Forms.Button btnReportEndOfDay;
        private System.Windows.Forms.DateTimePicker dtpRepastTime;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dgvSnacks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLunch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBreakfast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboKullaniciYiyecekForm;
        private System.Windows.Forms.GroupBox grpUserInformation;
        private System.Windows.Forms.Label lblTotalProtein;
        private System.Windows.Forms.Label lblTotalCarbohydrate;
        private System.Windows.Forms.Label lblTotalFat;
        private System.Windows.Forms.Label lblTotalCalorie;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnComparisons;
    }
}