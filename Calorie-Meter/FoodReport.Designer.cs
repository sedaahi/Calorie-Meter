namespace Calorie_Meter
{
    partial class FoodReport
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
            this.btnRepastBasedReport = new System.Windows.Forms.Button();
            this.btnFoodBasedReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRepastBasedReport
            // 
            this.btnRepastBasedReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRepastBasedReport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRepastBasedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRepastBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnRepastBasedReport.Location = new System.Drawing.Point(290, 135);
            this.btnRepastBasedReport.Name = "btnRepastBasedReport";
            this.btnRepastBasedReport.Size = new System.Drawing.Size(207, 115);
            this.btnRepastBasedReport.TabIndex = 3;
            this.btnRepastBasedReport.Text = "Repast Based Report";
            this.btnRepastBasedReport.UseVisualStyleBackColor = false;
            this.btnRepastBasedReport.Click += new System.EventHandler(this.btnRepastBasedReport_Click);
            // 
            // btnFoodBasedReport
            // 
            this.btnFoodBasedReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFoodBasedReport.BackColor = System.Drawing.Color.Salmon;
            this.btnFoodBasedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoodBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnFoodBasedReport.Location = new System.Drawing.Point(33, 135);
            this.btnFoodBasedReport.Name = "btnFoodBasedReport";
            this.btnFoodBasedReport.Size = new System.Drawing.Size(207, 115);
            this.btnFoodBasedReport.TabIndex = 2;
            this.btnFoodBasedReport.Text = "Food Based Report";
            this.btnFoodBasedReport.UseVisualStyleBackColor = false;
            this.btnFoodBasedReport.Click += new System.EventHandler(this.btnFoodBasedReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Calorie_Meter.Properties.Resources.balanced_diet;
            this.pictureBox1.Location = new System.Drawing.Point(191, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FoodReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRepastBasedReport);
            this.Controls.Add(this.btnFoodBasedReport);
            this.Name = "FoodReport";
            this.Text = "Food Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepastBasedReport;
        private System.Windows.Forms.Button btnFoodBasedReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}