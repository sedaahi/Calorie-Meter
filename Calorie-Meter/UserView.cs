using Calori_Meter.Data;
using Calorie_Meter.Data;
using Calorie_Meter.Data.Enums;
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
    public partial class UserView : Form
    {
        private readonly ApplicationDbContext db;
        private readonly User user;
        DateTime repastTime;
        public UserView(ApplicationDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            repastTime = dtpRepastTime.Value;
            ShowRepastsAll(repastTime);
            ShowUserInformation(repastTime);
        }

        private void ShowRepastsAll(DateTime repastTime)
        {
            ShowRepasts(repastTime, "Snacks", dgvSnacks);
            ShowRepasts(repastTime, "Breakfasts", dgvBreakfast);
            ShowRepasts(repastTime, "Lunches", dgvLunch);
            ShowRepasts(repastTime, "Dinners", dgvDinner);
        }

        private void ShowRepasts(DateTime repastTime, string repastName, DataGridView dataGridView)
        {
            if (user.Repasts.Count == 0 && user.Repasts.Any(x => x.Name == $"{repastName} {repastTime.Date}"))
            {
                dataGridView.DataSource = null;
                return;
            }

            else
            {
                if (user.Repasts.Any(x => x.Name == $"{repastName} {repastTime.Date}"))
                {
                    int id = (int)user.Repasts.FirstOrDefault(x => x.Name == $"{repastName} {repastTime.Date}").Id;
                    List<RepastFoodDetail> repastFoodDetails = db.RepastFoodDetails.Where(x => x.RepastId == id).ToList();

                    if (repastFoodDetails.Any(x => x.Repast == null))
                    {
                        dataGridView.DataSource = null;
                        return;
                    }
                    dataGridView.DataSource = repastFoodDetails.Select(x => new
                    {
                        x.Id,
                        x.FoodId,
                        Food = x.Food.Name,
                        x.Food.Protein,
                        x.Food.Fat,
                        x.Food.CarboHydrate,
                        x.Food.Calorie,
                        x.Food.Category.Name,
                        x.Portion,
                        x.Number
                    }).ToList();

                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                    ShowUserInformation(repastTime);
                }
                else
                    dataGridView.DataSource = null;
            }
        }

        private void ShowUserInformation(DateTime dateTime)
        {
            lblTotalCalorie.Text = $"Total Calorie(Today): 0";
            lblTotalCarbohydrate.Text = $"Total Carbohydrate(Today): 0";
            lblTotalFat.Text = $"Total Fat(Today): 0";
            lblTotalProtein.Text = $"Total Protein(Today): 0";
            grpUserInformation.Text = $"User Information ({repastTime.ToShortDateString()})";

            lblName.Text = $"Name: {user.Name}";
            if (user.Repasts.Any(x => x.Name.Contains($"{repastTime.Date}")))
            {
                List<Repast> repasts = user.Repasts.Where(x => x.Name.Contains($"{dateTime.Date}")).ToList();
                decimal totalCalorie = 0;
                decimal totalProtein = 0;
                decimal totalFat = 0;
                decimal totalCarboHydrate = 0;
                foreach (var item in repasts)
                {
                    totalCalorie += (decimal)item.TotalCalorieRepast;
                    totalFat += (decimal)item.TotalFatRepast;
                    totalProtein += (decimal)item.TotalProteinRepast;
                    totalCarboHydrate += (decimal)item.TotalCarboHydrateRepast;
                }
                lblTotalCalorie.Text = $"Total Calorie(Today): {totalCalorie.ToString("N2")}";
                lblTotalCarbohydrate.Text = $"Total Carbohydrate(Today): {totalCarboHydrate.ToString("N2")}";
                lblTotalProtein.Text = $"Total Protein(Today): {totalProtein.ToString("N2")}";
                lblTotalFat.Text = $"Total Fat(Today): {totalFat.ToString("N2")}";
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            RepastFoodDetail foodDetail = new RepastFoodDetail();
            string add = "addFood";
            AddFoodToRepast addFoodToRepast = new AddFoodToRepast(db, user, repastTime, add, foodDetail);
            this.Hide();
            addFoodToRepast.ShowDialog();
            this.Show();
            ShowRepastsAll(repastTime);
        }

        private void dtpRepastTime_ValueChanged(object sender, EventArgs e)
        {
            repastTime = dtpRepastTime.Value;
            ShowRepastsAll(repastTime);
            ShowUserInformation(repastTime);
        }

        private void dgvBreakfast_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string update = "updateFoodBreakfast";
            Repast repast = (Repast)user.Repasts.FirstOrDefault(x => x.Name == $"Breakfasts {repastTime.Date}");
            int id = (int)dgvBreakfast.SelectedRows[0].Cells[1].Value;
            RepastFoodDetail repastFoodDetail = (RepastFoodDetail)db.RepastFoodDetails.FirstOrDefault(x => x.Repast.Id == repast.Id && x.FoodId == id);
            AddFoodToRepast addFoodToRepast = new AddFoodToRepast(db, user, repastTime, update, repastFoodDetail);
            this.Hide();
            addFoodToRepast.ShowDialog();
            this.Show();
            ShowRepastsAll(repastTime);
        }

        private void dgvLunch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string update = "updateFoodLunch";
            int id = (int)dgvLunch.SelectedRows[0].Cells[1].Value;
            Repast repast = (Repast)user.Repasts.FirstOrDefault(x => x.Name == $"Lunches {repastTime.Date}");
            RepastFoodDetail repastFoodDetail = (RepastFoodDetail)db.RepastFoodDetails.FirstOrDefault(x => x.Repast.Id == repast.Id && x.FoodId == id);
            AddFoodToRepast addFoodToRepast = new AddFoodToRepast(db, user, repastTime, update, repastFoodDetail);
            this.Hide();
            addFoodToRepast.ShowDialog();
            this.Show();
            ShowRepastsAll(repastTime);
        }

       

        private void dgvSnacks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string update = "updateFoodSnack";
            int id = (int)dgvSnacks.SelectedRows[0].Cells[1].Value;
            Repast repast = (Repast)user.Repasts.FirstOrDefault(x => x.Name == $"Snacks {repastTime.Date}");
            RepastFoodDetail repastFoodDetail = (RepastFoodDetail)db.RepastFoodDetails.FirstOrDefault(x => x.Repast.Id == repast.Id && x.FoodId == id);
            AddFoodToRepast addFoodToRepast = new AddFoodToRepast(db, user, repastTime, update, repastFoodDetail);
            this.Hide();
            addFoodToRepast.ShowDialog();
            this.Show();
            ShowRepastsAll(repastTime);
        }

        private void dgvBreakfast_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteKeyDown(e, "Breakfasts", dgvBreakfast, "Breakfast");

        }

        private void dgvLunch_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteKeyDown(e, "Lunches", dgvLunch, "Lunch");
        }

        private void dgvDinner_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteKeyDown(e, "Dinners", dgvDinner, "Dinner");
        }

        private void dgvSnacks_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteKeyDown(e, "Snacks", dgvSnacks, "Snack");
        }

        private void DeleteFoodMethod(double a, Food deletedFood, RepastFoodDetail repastFoodDetail, Repast repast, string code)
        {
            deletedFood.CountOfTotalEating -= repastFoodDetail.Number;
            if (code == "Breakfast")
                deletedFood.CountOfEatingBreakfeast -= repastFoodDetail.Number;
            else if (code == "Lunch")
                deletedFood.CountOfEatingLunch -= repastFoodDetail.Number;
            else if (code == "Dinner")
                deletedFood.CountOfEatingDinner -= repastFoodDetail.Number;
            else if (code == "Snack")
                deletedFood.CountOfEatingSnack -= repastFoodDetail.Number;

            repast.TotalProteinRepast -= Math.Round((deletedFood.Protein * a * repastFoodDetail.Number), 2);
            repast.TotalFatRepast -= Math.Round((deletedFood.Fat * a * repastFoodDetail.Number), 2);
            repast.TotalCarboHydrateRepast -= Math.Round((deletedFood.CarboHydrate * a * repastFoodDetail.Number), 2);
            repast.TotalCalorieRepast -= Math.Round((deletedFood.Calorie * a * repastFoodDetail.Number), 2);

        }

        private void DeleteKeyDown(KeyEventArgs e, string repastName, DataGridView dataGridView, string code)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            double a;
            int id = (int)dataGridView.SelectedRows[0].Cells[1].Value;
            Food deletedFood = db.Foods.Find(id);

            //TODO: öğünün içinde bir adet öğün detay kaldıysa ve bu evente gelmişse öğünü sil


            Repast repast = user.Repasts.FirstOrDefault(x => x.Name == $"{repastName} {repastTime.Date}");

            
            RepastFoodDetail repastFoodDetail = db.RepastFoodDetails.FirstOrDefault(x => x.Repast.Id == repast.Id && x.FoodId == deletedFood.Id);

            if (repastFoodDetail.Portion == PortionPreference.Half)
                a = 0.5;
            else if (repastFoodDetail.Portion == PortionPreference.Full)
                a = 1;
            else
                a = 1.5;

            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show($"Do you want to delete {deletedFood.Name}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    if (repast.RepastFoodDetails.Count == 1)
                    {
                        DeleteFoodMethod(a, deletedFood, repastFoodDetail, repast, code);
                        db.RepastFoodDetails.Remove(repastFoodDetail);
                        db.Repasts.Remove(repast);
                        db.SaveChanges();
                        ShowUserInformation(repastTime.Date);
                        ShowRepastsAll(repastTime);

                    }
                    else
                    {
                        DeleteFoodMethod(a, deletedFood, repastFoodDetail, repast, code);
                        db.RepastFoodDetails.Remove(repastFoodDetail);
                        db.SaveChanges();
                        ShowRepastsAll(repastTime);
                    }
                }
                else
                    return;
            }
        }

        private void btnReportEndOfDay_Click(object sender, EventArgs e)
        {
            EndOfDayReport endOfDayReport = new EndOfDayReport(db, user, repastTime);
            this.Hide();
            endOfDayReport.ShowDialog();
            this.Show();
        }

        private void btnFoodReport_Click(object sender, EventArgs e)
        {
            FoodReport foodReport = new FoodReport(db);
            this.Hide();
            foodReport.ShowDialog();
            this.Show();
        }

        private void btnComparisons_Click(object sender, EventArgs e)
        {
            ComparisonReport comparisonReport = new ComparisonReport(db, user);
            this.Hide();
            comparisonReport.ShowDialog();
            this.Show();
        }

        private void dgvDinner_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string update = "updateFoodDinner";
            int id = (int)dgvDinner.SelectedRows[0].Cells[1].Value;
            Repast repast = (Repast)user.Repasts.FirstOrDefault(x => x.Name == $"Dinners {repastTime.Date}");
            RepastFoodDetail repastFoodDetail = (RepastFoodDetail)db.RepastFoodDetails.FirstOrDefault(x => x.Repast.Id == repast.Id && x.FoodId == id);
            AddFoodToRepast addFoodToRepast = new AddFoodToRepast(db, user, repastTime, update, repastFoodDetail);
            this.Hide();
            addFoodToRepast.ShowDialog();
            this.Show();
            ShowRepastsAll(repastTime);
        }
    }
}
