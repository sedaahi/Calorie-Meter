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
    public partial class FoodReport : Form
    {
        private readonly ApplicationDbContext db;

        public FoodReport(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnFoodBasedReport_Click(object sender, EventArgs e)
        {
            FoodBasedReportcs foodBasedReportcs = new FoodBasedReportcs(db);
            this.Hide();
            foodBasedReportcs.ShowDialog();
            this.Show();
        }

        private void btnRepastBasedReport_Click(object sender, EventArgs e)
        {
            RepastBasedReport repastBasedReport = new RepastBasedReport(db);
            this.Hide();
            repastBasedReport.ShowDialog();
            this.Show();
        }
    }
}
