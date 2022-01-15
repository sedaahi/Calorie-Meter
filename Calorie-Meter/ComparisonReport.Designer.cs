namespace Calorie_Meter
{
    partial class ComparisonReport
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
            this.btnRepastBasedComparison = new System.Windows.Forms.Button();
            this.btnCategoryBasedComparison = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRepastBasedComparison
            // 
            this.btnRepastBasedComparison.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRepastBasedComparison.BackColor = System.Drawing.Color.Tomato;
            this.btnRepastBasedComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRepastBasedComparison.ForeColor = System.Drawing.Color.White;
            this.btnRepastBasedComparison.Location = new System.Drawing.Point(27, 102);
            this.btnRepastBasedComparison.Name = "btnRepastBasedComparison";
            this.btnRepastBasedComparison.Size = new System.Drawing.Size(184, 97);
            this.btnRepastBasedComparison.TabIndex = 0;
            this.btnRepastBasedComparison.Text = "Repast Based Comparison";
            this.btnRepastBasedComparison.UseVisualStyleBackColor = false;
            this.btnRepastBasedComparison.Click += new System.EventHandler(this.btnRepastBasedComparison_Click);
            // 
            // btnCategoryBasedComparison
            // 
            this.btnCategoryBasedComparison.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategoryBasedComparison.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCategoryBasedComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryBasedComparison.ForeColor = System.Drawing.Color.White;
            this.btnCategoryBasedComparison.Location = new System.Drawing.Point(247, 102);
            this.btnCategoryBasedComparison.Name = "btnCategoryBasedComparison";
            this.btnCategoryBasedComparison.Size = new System.Drawing.Size(184, 97);
            this.btnCategoryBasedComparison.TabIndex = 1;
            this.btnCategoryBasedComparison.Text = "Category Based Comparison";
            this.btnCategoryBasedComparison.UseVisualStyleBackColor = false;
            this.btnCategoryBasedComparison.Click += new System.EventHandler(this.btnCategoryBasedComparison_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Calorie_Meter.Properties.Resources.balance_sheet;
            this.pictureBox1.Location = new System.Drawing.Point(165, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ComparisonReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(457, 229);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCategoryBasedComparison);
            this.Controls.Add(this.btnRepastBasedComparison);
            this.Name = "ComparisonReport";
            this.Text = "ComparisonReport";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepastBasedComparison;
        private System.Windows.Forms.Button btnCategoryBasedComparison;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}