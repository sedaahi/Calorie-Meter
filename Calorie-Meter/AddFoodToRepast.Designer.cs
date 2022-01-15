namespace Calorie_Meter
{
    partial class AddFoodToRepast
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
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPortion = new System.Windows.Forms.ComboBox();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.btnAddToSnacks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.btnAddNewFood = new System.Windows.Forms.Button();
            this.btnAddToDinner = new System.Windows.Forms.Button();
            this.btnAddToLunch = new System.Windows.Forms.Button();
            this.btnAddToBreakfast = new System.Windows.Forms.Button();
            this.pbFoodPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "How Many?";
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(176, 92);
            this.nudNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 20);
            this.nudNumber.TabIndex = 42;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(681, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Please Choose Portion:";
            // 
            // cboPortion
            // 
            this.cboPortion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPortion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPortion.FormattingEnabled = true;
            this.cboPortion.Location = new System.Drawing.Point(831, 91);
            this.cboPortion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPortion.Name = "cboPortion";
            this.cboPortion.Size = new System.Drawing.Size(116, 21);
            this.cboPortion.TabIndex = 39;
            this.cboPortion.SelectedIndexChanged += new System.EventHandler(this.cboPortion_SelectedIndexChanged);
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(176, 132);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(771, 321);
            this.dgvFoods.TabIndex = 38;
            this.dgvFoods.SelectionChanged += new System.EventHandler(this.dgvFoods_SelectionChanged);
            // 
            // btnAddToSnacks
            // 
            this.btnAddToSnacks.BackColor = System.Drawing.Color.Plum;
            this.btnAddToSnacks.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddToSnacks.ForeColor = System.Drawing.Color.White;
            this.btnAddToSnacks.Location = new System.Drawing.Point(23, 382);
            this.btnAddToSnacks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToSnacks.Name = "btnAddToSnacks";
            this.btnAddToSnacks.Size = new System.Drawing.Size(121, 80);
            this.btnAddToSnacks.TabIndex = 37;
            this.btnAddToSnacks.Text = "ADD TO SNACKS";
            this.btnAddToSnacks.UseVisualStyleBackColor = false;
            this.btnAddToSnacks.Click += new System.EventHandler(this.btnAddToSnacks_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Categories";
            // 
            // cboCategories
            // 
            this.cboCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(176, 35);
            this.cboCategories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(770, 21);
            this.cboCategories.TabIndex = 35;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            // 
            // btnAddNewFood
            // 
            this.btnAddNewFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewFood.BackColor = System.Drawing.Color.Purple;
            this.btnAddNewFood.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewFood.ForeColor = System.Drawing.Color.White;
            this.btnAddNewFood.Location = new System.Drawing.Point(771, 459);
            this.btnAddNewFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewFood.Name = "btnAddNewFood";
            this.btnAddNewFood.Size = new System.Drawing.Size(176, 35);
            this.btnAddNewFood.TabIndex = 34;
            this.btnAddNewFood.Text = "Add New Food";
            this.btnAddNewFood.UseVisualStyleBackColor = false;
            this.btnAddNewFood.Click += new System.EventHandler(this.btnAddNewFood_Click);
            // 
            // btnAddToDinner
            // 
            this.btnAddToDinner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddToDinner.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddToDinner.ForeColor = System.Drawing.Color.White;
            this.btnAddToDinner.Location = new System.Drawing.Point(23, 301);
            this.btnAddToDinner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToDinner.Name = "btnAddToDinner";
            this.btnAddToDinner.Size = new System.Drawing.Size(121, 80);
            this.btnAddToDinner.TabIndex = 32;
            this.btnAddToDinner.Text = "ADD TO DINNER";
            this.btnAddToDinner.UseVisualStyleBackColor = false;
            this.btnAddToDinner.Click += new System.EventHandler(this.btnAddToDinner_Click);
            // 
            // btnAddToLunch
            // 
            this.btnAddToLunch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddToLunch.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddToLunch.ForeColor = System.Drawing.Color.White;
            this.btnAddToLunch.Location = new System.Drawing.Point(23, 218);
            this.btnAddToLunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToLunch.Name = "btnAddToLunch";
            this.btnAddToLunch.Size = new System.Drawing.Size(121, 80);
            this.btnAddToLunch.TabIndex = 31;
            this.btnAddToLunch.Text = "ADD TO LUNCH";
            this.btnAddToLunch.UseVisualStyleBackColor = false;
            this.btnAddToLunch.Click += new System.EventHandler(this.btnAddToLunch_Click);
            // 
            // btnAddToBreakfast
            // 
            this.btnAddToBreakfast.BackColor = System.Drawing.Color.Orange;
            this.btnAddToBreakfast.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddToBreakfast.ForeColor = System.Drawing.Color.White;
            this.btnAddToBreakfast.Location = new System.Drawing.Point(23, 132);
            this.btnAddToBreakfast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToBreakfast.Name = "btnAddToBreakfast";
            this.btnAddToBreakfast.Size = new System.Drawing.Size(121, 80);
            this.btnAddToBreakfast.TabIndex = 30;
            this.btnAddToBreakfast.Text = "ADD TO BREAKFAST";
            this.btnAddToBreakfast.UseVisualStyleBackColor = false;
            this.btnAddToBreakfast.Click += new System.EventHandler(this.btnAddToBreakfast_Click);
            // 
            // pbFoodPicture
            // 
            this.pbFoodPicture.Location = new System.Drawing.Point(23, 19);
            this.pbFoodPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbFoodPicture.Name = "pbFoodPicture";
            this.pbFoodPicture.Size = new System.Drawing.Size(121, 93);
            this.pbFoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodPicture.TabIndex = 33;
            this.pbFoodPicture.TabStop = false;
            // 
            // AddFoodToRepast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPortion);
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.btnAddToSnacks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.btnAddNewFood);
            this.Controls.Add(this.pbFoodPicture);
            this.Controls.Add(this.btnAddToDinner);
            this.Controls.Add(this.btnAddToLunch);
            this.Controls.Add(this.btnAddToBreakfast);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddFoodToRepast";
            this.Text = "AddFoodToRepast";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPortion;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.Button btnAddToSnacks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.Button btnAddNewFood;
        private System.Windows.Forms.PictureBox pbFoodPicture;
        private System.Windows.Forms.Button btnAddToDinner;
        private System.Windows.Forms.Button btnAddToLunch;
        private System.Windows.Forms.Button btnAddToBreakfast;
    }
}