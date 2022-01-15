using Calori_Meter.Data;
using Calorie_Meter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Meter
{
    public partial class ComparisonReport : Form
    {
        private readonly ApplicationDbContext db;
        private readonly User user;

        public ComparisonReport(ApplicationDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
        }

        private void btnRepastBasedComparison_Click(object sender, EventArgs e)
        {
            RepastBasedComparison repastBasedComparison = new RepastBasedComparison(db,user);
            this.Hide();
            repastBasedComparison.ShowDialog();
            this.Show();
        }

        private void btnCategoryBasedComparison_Click(object sender, EventArgs e)
        {
            CategoryBasedComparison categoryBasedComparison = new CategoryBasedComparison(db, user);
            this.Hide();
            categoryBasedComparison.ShowDialog();
            this.Show();
        }
    }
}
