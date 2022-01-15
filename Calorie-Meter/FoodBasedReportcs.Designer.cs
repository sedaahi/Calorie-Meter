namespace Calorie_Meter
{
    partial class FoodBasedReportcs
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMostEatenFood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFoodReport = new System.Windows.Forms.DataGridView();
            this.pbFoodPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Tomato;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(554, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 41);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblMostEatenFood
            // 
            this.lblMostEatenFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostEatenFood.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMostEatenFood.ForeColor = System.Drawing.Color.Tomato;
            this.lblMostEatenFood.Location = new System.Drawing.Point(434, 59);
            this.lblMostEatenFood.Name = "lblMostEatenFood";
            this.lblMostEatenFood.Size = new System.Drawing.Size(213, 77);
            this.lblMostEatenFood.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(416, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Most Eaten Food :";
            // 
            // dgvFoodReport
            // 
            this.dgvFoodReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoodReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodReport.Location = new System.Drawing.Point(10, 12);
            this.dgvFoodReport.Name = "dgvFoodReport";
            this.dgvFoodReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodReport.Size = new System.Drawing.Size(400, 426);
            this.dgvFoodReport.TabIndex = 5;
            // 
            // pbFoodPicture
            // 
            this.pbFoodPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoodPicture.Location = new System.Drawing.Point(425, 177);
            this.pbFoodPicture.Name = "pbFoodPicture";
            this.pbFoodPicture.Size = new System.Drawing.Size(240, 186);
            this.pbFoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodPicture.TabIndex = 8;
            this.pbFoodPicture.TabStop = false;
            // 
            // FoodBasedReportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbFoodPicture);
            this.Controls.Add(this.lblMostEatenFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFoodReport);
            this.Name = "FoodBasedReportcs";
            this.Text = "FoodBasedReportcs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbFoodPicture;
        private System.Windows.Forms.Label lblMostEatenFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFoodReport;
    }
}