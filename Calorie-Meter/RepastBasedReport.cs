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
    public partial class RepastBasedReport : Form
    {
        private readonly ApplicationDbContext db;

        public RepastBasedReport(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadRepastsAndFoods();
        }

        private void LoadRepastsAndFoods()
        {
            if (db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Breakfasts")) == null)
                dgvBreakfastsFood.DataSource = null;
            else
            {
                List<RepastFoodDetail> repastBreakfast = db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Breakfasts")).ToList();
                dgvBreakfastsFood.DataSource = repastBreakfast.Select(x => new
                {
                    x.FoodId,
                    x.Food.Name,
                    x.Food.CountOfEatingBreakfeast
                }).OrderByDescending(x => x.CountOfEatingBreakfeast).Distinct().ToList();

                dgvBreakfastsFood.Columns[0].Visible = false;

                if (repastBreakfast.Count == 0)
                    dgvBreakfastsFood.DataSource = null;
                else
                {
                    int id = (int)dgvBreakfastsFood.Rows[0].Cells[0].Value;
                    Food food = db.Foods.Find(id);
                    lblTheMostEatenOnBreakfast.Text = food.Name;
                }
            }

            if (db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Lunches")) == null)
                dgvLunchesFood.DataSource = null;
            else
            {
                List<RepastFoodDetail> repastLunch = db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Lunches")).ToList();
                dgvLunchesFood.DataSource = repastLunch.Select(x => new
                {
                    x.FoodId,
                    x.Food.Name,
                    x.Food.CountOfEatingLunch
                }).OrderByDescending(x => x.CountOfEatingLunch).Distinct().ToList();

                dgvLunchesFood.Columns[0].Visible = false;

                if (repastLunch.Count == 0)
                    dgvLunchesFood.DataSource = null;
                else
                {
                    int id = (int)dgvLunchesFood.Rows[0].Cells[0].Value;
                    Food food = db.Foods.Find(id);
                    lblTheMostEatenOnLunch.Text = food.Name;
                }
            }

            if (db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Dinners")) == null)
                dgvDinnersFood.DataSource = null;
            else
            {
                List<RepastFoodDetail> repastDinner = db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Dinners")).ToList();
                dgvDinnersFood.DataSource = repastDinner.Select(x => new
                {
                    x.FoodId,
                    x.Food.Name,
                    x.Food.CountOfEatingDinner
                }).OrderByDescending(x => x.CountOfEatingDinner).Distinct().ToList();

                dgvDinnersFood.Columns[0].Visible = false;

                if (repastDinner.Count == 0)
                    dgvDinnersFood.DataSource = null;
                else
                {
                    int id = (int)dgvDinnersFood.Rows[0].Cells[0].Value;
                    Food food = db.Foods.Find(id);
                    lblTheMostEatenOnDınner.Text = food.Name;
                }
            }

            if (db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Snacks")) == null)
                dgvSnacksFood.DataSource = null;
            else
            {
                List<RepastFoodDetail> repastSnacks = db.RepastFoodDetails.Where(x => x.Repast.Name.StartsWith("Snacks")).ToList();
                dgvSnacksFood.DataSource = repastSnacks.Select(x => new
                {
                    x.FoodId,
                    x.Food.Name,
                    x.Food.CountOfEatingSnack
                }).OrderByDescending(x => x.CountOfEatingSnack).Distinct().ToList();

                dgvSnacksFood.Columns[0].Visible = false;

                if (repastSnacks.Count == 0)
                    dgvSnacksFood.DataSource = null;
                else
                {
                    int id = (int)dgvSnacksFood.Rows[0].Cells[0].Value;
                    Food food = db.Foods.Find(id);
                    lblTheMostEatenSnack.Text = food.Name;
                }


            }
        }

        private void btnBackRepastReport_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
