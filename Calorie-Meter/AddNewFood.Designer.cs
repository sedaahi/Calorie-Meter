namespace Calorie_Meter
{
    partial class AddNewFood
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
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCalorie = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFatValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCarbohhydrateValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudProteinValue = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFoodPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFatValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbohhydrateValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProteinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(12, 377);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(190, 21);
            this.cboCategory.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(46, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Calorie (per 100gr)";
            // 
            // nudCalorie
            // 
            this.nudCalorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudCalorie.DecimalPlaces = 2;
            this.nudCalorie.Location = new System.Drawing.Point(12, 310);
            this.nudCalorie.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCalorie.Name = "nudCalorie";
            this.nudCalorie.Size = new System.Drawing.Size(190, 20);
            this.nudCalorie.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fat Value (per 100gr)";
            // 
            // nudFatValue
            // 
            this.nudFatValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudFatValue.DecimalPlaces = 2;
            this.nudFatValue.Location = new System.Drawing.Point(12, 257);
            this.nudFatValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudFatValue.Name = "nudFatValue";
            this.nudFatValue.Size = new System.Drawing.Size(190, 20);
            this.nudFatValue.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Carbohydrate Value (per 100gr)";
            // 
            // nudCarbohhydrateValue
            // 
            this.nudCarbohhydrateValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudCarbohhydrateValue.DecimalPlaces = 2;
            this.nudCarbohhydrateValue.Location = new System.Drawing.Point(12, 204);
            this.nudCarbohhydrateValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCarbohhydrateValue.Name = "nudCarbohhydrateValue";
            this.nudCarbohhydrateValue.Size = new System.Drawing.Size(190, 20);
            this.nudCarbohhydrateValue.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Protein Value (per 100gr)";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImagePath.Location = new System.Drawing.Point(12, 433);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(190, 20);
            this.txtImagePath.TabIndex = 23;
            this.txtImagePath.TextChanged += new System.EventHandler(this.txtImagePath_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Image Path";
            // 
            // nudProteinValue
            // 
            this.nudProteinValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudProteinValue.DecimalPlaces = 2;
            this.nudProteinValue.Location = new System.Drawing.Point(12, 151);
            this.nudProteinValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudProteinValue.Name = "nudProteinValue";
            this.nudProteinValue.Size = new System.Drawing.Size(190, 20);
            this.nudProteinValue.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(127, 559);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(12, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Food Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Calorie_Meter.Properties.Resources.diet__2_;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pbFoodPicture
            // 
            this.pbFoodPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoodPicture.Location = new System.Drawing.Point(12, 459);
            this.pbFoodPicture.Name = "pbFoodPicture";
            this.pbFoodPicture.Size = new System.Drawing.Size(190, 83);
            this.pbFoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodPicture.TabIndex = 31;
            this.pbFoodPicture.TabStop = false;
            // 
            // AddNewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(226, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbFoodPicture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCalorie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudFatValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCarbohhydrateValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudProteinValue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddNewFood";
            this.Text = "AddNewFood";
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFatValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbohhydrateValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProteinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbFoodPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCalorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFatValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCarbohhydrateValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudProteinValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}