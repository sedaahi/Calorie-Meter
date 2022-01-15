namespace Calorie_Meter
{
    partial class CategoryBasedComparison
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExitUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboWeeklyMonthlyUser = new System.Windows.Forms.ComboBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnShowUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoryUser = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExitAllUsers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboWeeklyMonthlyAllUsers = new System.Windows.Forms.ComboBox();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategoryAllUsers = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.btnExitUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboWeeklyMonthlyUser);
            this.tabPage1.Controls.Add(this.dgvUser);
            this.tabPage1.Controls.Add(this.btnShowUser);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboCategoryUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            // 
            // btnExitUser
            // 
            this.btnExitUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExitUser.BackColor = System.Drawing.Color.Tomato;
            this.btnExitUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExitUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnExitUser.Location = new System.Drawing.Point(167, 109);
            this.btnExitUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitUser.Name = "btnExitUser";
            this.btnExitUser.Size = new System.Drawing.Size(125, 36);
            this.btnExitUser.TabIndex = 12;
            this.btnExitUser.Text = "Exit";
            this.btnExitUser.UseVisualStyleBackColor = false;
            this.btnExitUser.Click += new System.EventHandler(this.btnExitUser_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Weekly/Monthly:";
            // 
            // cboWeeklyMonthlyUser
            // 
            this.cboWeeklyMonthlyUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboWeeklyMonthlyUser.FormattingEnabled = true;
            this.cboWeeklyMonthlyUser.Location = new System.Drawing.Point(137, 61);
            this.cboWeeklyMonthlyUser.Margin = new System.Windows.Forms.Padding(4);
            this.cboWeeklyMonthlyUser.Name = "cboWeeklyMonthlyUser";
            this.cboWeeklyMonthlyUser.Size = new System.Drawing.Size(288, 24);
            this.cboWeeklyMonthlyUser.TabIndex = 10;
            // 
            // dgvUser
            // 
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(11, 153);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(416, 229);
            this.dgvUser.TabIndex = 9;
            // 
            // btnShowUser
            // 
            this.btnShowUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowUser.BackColor = System.Drawing.Color.ForestGreen;
            this.btnShowUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowUser.ForeColor = System.Drawing.Color.White;
            this.btnShowUser.Location = new System.Drawing.Point(300, 109);
            this.btnShowUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowUser.Name = "btnShowUser";
            this.btnShowUser.Size = new System.Drawing.Size(125, 36);
            this.btnShowUser.TabIndex = 8;
            this.btnShowUser.Text = "Show";
            this.btnShowUser.UseVisualStyleBackColor = false;
            this.btnShowUser.Click += new System.EventHandler(this.btnShowUser_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category:";
            // 
            // cboCategoryUser
            // 
            this.cboCategoryUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCategoryUser.FormattingEnabled = true;
            this.cboCategoryUser.Location = new System.Drawing.Point(137, 11);
            this.cboCategoryUser.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoryUser.Name = "cboCategoryUser";
            this.cboCategoryUser.Size = new System.Drawing.Size(288, 24);
            this.cboCategoryUser.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.btnExitAllUsers);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cboWeeklyMonthlyAllUsers);
            this.tabPage2.Controls.Add(this.dgvAllUsers);
            this.tabPage2.Controls.Add(this.btnShowAllUsers);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cboCategoryAllUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Users";
            // 
            // btnExitAllUsers
            // 
            this.btnExitAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExitAllUsers.BackColor = System.Drawing.Color.Tomato;
            this.btnExitAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExitAllUsers.ForeColor = System.Drawing.Color.White;
            this.btnExitAllUsers.Location = new System.Drawing.Point(169, 110);
            this.btnExitAllUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitAllUsers.Name = "btnExitAllUsers";
            this.btnExitAllUsers.Size = new System.Drawing.Size(125, 36);
            this.btnExitAllUsers.TabIndex = 13;
            this.btnExitAllUsers.Text = "Exit";
            this.btnExitAllUsers.UseVisualStyleBackColor = false;
            this.btnExitAllUsers.Click += new System.EventHandler(this.btnExitAllUsers_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Weekly/Monthly:";
            // 
            // cboWeeklyMonthlyAllUsers
            // 
            this.cboWeeklyMonthlyAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboWeeklyMonthlyAllUsers.FormattingEnabled = true;
            this.cboWeeklyMonthlyAllUsers.Location = new System.Drawing.Point(137, 61);
            this.cboWeeklyMonthlyAllUsers.Margin = new System.Windows.Forms.Padding(4);
            this.cboWeeklyMonthlyAllUsers.Name = "cboWeeklyMonthlyAllUsers";
            this.cboWeeklyMonthlyAllUsers.Size = new System.Drawing.Size(288, 24);
            this.cboWeeklyMonthlyAllUsers.TabIndex = 10;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Location = new System.Drawing.Point(11, 153);
            this.dgvAllUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(416, 229);
            this.dgvAllUsers.TabIndex = 9;
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowAllUsers.BackColor = System.Drawing.Color.ForestGreen;
            this.btnShowAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowAllUsers.ForeColor = System.Drawing.Color.White;
            this.btnShowAllUsers.Location = new System.Drawing.Point(302, 110);
            this.btnShowAllUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(125, 36);
            this.btnShowAllUsers.TabIndex = 8;
            this.btnShowAllUsers.Text = "Show";
            this.btnShowAllUsers.UseVisualStyleBackColor = false;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category:";
            // 
            // cboCategoryAllUsers
            // 
            this.cboCategoryAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCategoryAllUsers.FormattingEnabled = true;
            this.cboCategoryAllUsers.Location = new System.Drawing.Point(137, 11);
            this.cboCategoryAllUsers.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoryAllUsers.Name = "cboCategoryAllUsers";
            this.cboCategoryAllUsers.Size = new System.Drawing.Size(288, 24);
            this.cboCategoryAllUsers.TabIndex = 6;
            // 
            // CategoryBasedComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 445);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryBasedComparison";
            this.Text = "CategoryBasedComparison";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboWeeklyMonthlyUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnShowUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategoryUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboWeeklyMonthlyAllUsers;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCategoryAllUsers;
        private System.Windows.Forms.Button btnExitUser;
        private System.Windows.Forms.Button btnExitAllUsers;
    }
}