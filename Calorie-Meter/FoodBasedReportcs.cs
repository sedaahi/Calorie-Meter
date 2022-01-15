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
    public partial class FoodBasedReportcs : Form
    {
        private readonly ApplicationDbContext db;

        public FoodBasedReportcs(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadFood();
        }

        private void LoadFood()
        {
            dgvFoodReport.DataSource = db.Foods.Select(x => new
            {
                x.Id,
                x.Name,
                x.CountOfTotalEating
            }).OrderByDescending(t => t.CountOfTotalEating).ToList();

            var countEat = db.Foods.Max(x => x.CountOfTotalEating);
            Food food = db.Foods.FirstOrDefault(x => x.CountOfTotalEating == countEat);
            
            lblMostEatenFood.Text = food.Name;

            pbFoodPicture.ImageLocation = food.ImagePath;
            pbFoodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
