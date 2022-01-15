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
    public partial class AddNewFood : Form
    {
        private readonly ApplicationDbContext db;

        public AddNewFood(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadCategories();
        }


        private void LoadCategories()
        {
            cboCategory.DataSource = db.Categorys.ToList();
            cboCategory.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                MessageBox.Show("Please enter food informations!");
                return;
            }
            Food food = new Food() 
            {
                Name = txtName.Text.Trim(),
                CarboHydrate = (double)nudCarbohhydrateValue.Value,
                Protein = (double)nudProteinValue.Value,
                Fat = (double)nudFatValue.Value,
                Calorie = (double)nudCalorie.Value,
                ImagePath = txtImagePath.Text.Trim(),
                Category = (Category)cboCategory.SelectedItem
            };
            db.Foods.Add(food);
            db.SaveChanges();
            Close();
        }

        private void txtImagePath_TextChanged(object sender, EventArgs e)
        {
            pbFoodPicture.ImageLocation = txtImagePath.Text.Trim();
            pbFoodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
