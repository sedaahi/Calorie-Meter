using Calori_Meter.Data;
using Calorie_Meter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Meter
{
    public partial class RepastBasedComparison : Form
    {
        private readonly ApplicationDbContext db;
        private readonly User user;

        public RepastBasedComparison(ApplicationDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
        }


        private void ShowRepastsAllUser(DataGridView dataGridView, string repastName, int dateTime, string code)
        {
            var passTime = DateTime.Now.AddDays(-dateTime);
            var nowTime = DateTime.Now.Date;
            List<Repast> userRepasts = db.Repasts
                .ToList()
                .Where(x => x.Name.StartsWith($"{repastName}") && (x.Date <= nowTime && x.Date >= passTime))
                .ToList();

            List<RepastFoodDetail> userRepastFoodDetail = new List<RepastFoodDetail>();

            foreach (var item in userRepasts)
            {
                foreach (var item2 in item.RepastFoodDetails)
                {
                    userRepastFoodDetail.Add(item2);
                }
            }

            decimal totalCalorie = 0;

            foreach (var item in userRepastFoodDetail)
            {
                totalCalorie += (decimal)item.Repast.TotalCalorieRepast;
            }

            if (db.RepastFoodDetails
                .Where(x => x.Repast.Date <= nowTime && x.Repast.Date >= passTime)
                .ToList()
                .Where(y => y.Repast.Name.StartsWith($"{repastName}")).Count() == 0)
            {
                return;
            }
            totalCalorie /= db.RepastFoodDetails
                .Where(x => x.Repast.Date <= nowTime && x.Repast.Date >= passTime)
                .ToList()
                .Where(y => y.Repast.Name.StartsWith($"{repastName}")).Count();

            if (code == "breakfasts")
            {
                dataGridView.DataSource = userRepastFoodDetail.Select(x => new
                {
                    x.Food.Name,
                    x.Food.CountOfEatingBreakfeast
                }).OrderByDescending(z => z.CountOfEatingBreakfeast).Distinct().Take(5).ToList();
                lblBreakfastAvrAllUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");
            }

            else if (code == "lunches")
            {
                dataGridView.DataSource = userRepastFoodDetail.Select(x => new
                {
                    x.Food.Name,
                    x.Food.CountOfEatingLunch
                }).OrderByDescending(z => z.CountOfEatingLunch).Distinct().Take(5).ToList();
                lblLunchAvrAllUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");
            }

            else if (code == "dinners")
            {
                dataGridView.DataSource = userRepastFoodDetail.Select(x => new
                {
                    x.Food.Name,
                    x.Food.CountOfEatingDinner
                }).OrderByDescending(z => z.CountOfEatingDinner).Distinct().Take(5).ToList();
                lblDinnerAvrAllUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");
            }

            else if (code == "snacks")
            {
                dataGridView.DataSource = userRepastFoodDetail.Select(x => new
                {
                    x.Food.Name,
                    x.Food.CountOfEatingSnack
                }).OrderByDescending(z => z.CountOfEatingSnack).Distinct().Take(5).ToList();
                lblSnacksAvrAllUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");
            }

            
        }
        private void ShowRepastsUser(DataGridView dataGridView, string repastName, int dateTime, string code)
        {
            var passTime = DateTime.Now.AddDays(-dateTime);
            var nowTime = DateTime.Now.Date;
            List<Repast> userRepasts = user.Repasts
                .Where(x => x.Name.StartsWith($"{repastName}") && (x.Date <= nowTime && x.Date >= passTime))
                .ToList();
            if (userRepasts.Count == 0)
            {
                return;
            }
            List<RepastFoodDetail> userRepastFoodDetail = new List<RepastFoodDetail>();

            foreach (var item in userRepasts)
            {
                foreach (var item2 in item.RepastFoodDetails)
                {
                    userRepastFoodDetail.Add(item2);
                }
            }

            dataGridView.DataSource = userRepastFoodDetail.GroupBy(x => x.Food.Name).Select(y => new
            {
                Name = y.Key,
                Count = y.Sum(s => s.Number)
            }).OrderByDescending(z => z.Count).ToList();

            decimal totalCalorie = 0;

            foreach (var item in userRepasts)
            {
                totalCalorie += (decimal)item.TotalCalorieRepast;
            }

            totalCalorie /= (userRepasts.Count);

            if (code == "breakfasts")
                lblBreakfastAvrUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");
            else if (code == "lunches")
                lblLunchAvrUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");
            else if (code == "dinners")
                lblDinnerAvrUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");
            else if (code == "snacks")
                lblSnacksAvrUser.Text = "Average Calorie: " + totalCalorie.ToString("N2");

        }

        private void btnWeeklyUser_Click(object sender, EventArgs e)
        {
            dgvBreakfastUser.DataSource = null;
            dgvLunchUser.DataSource = null;
            dgvDinnerUser.DataSource = null;
            dgvSnackUser.DataSource = null;

            ShowRepastsUser(dgvBreakfastUser, "Breakfasts", 7, "breakfasts");
            ShowRepastsUser(dgvLunchUser, "Lunches", 7, "lunches");
            ShowRepastsUser(dgvDinnerUser, "Dinners", 7, "dinners");
            ShowRepastsUser(dgvSnackUser, "Snacks", 7, "snacks");

        }

        private void btnMonthlyUser_Click(object sender, EventArgs e)
        {
            dgvBreakfastUser.DataSource = null;
            dgvLunchUser.DataSource = null;
            dgvDinnerUser.DataSource = null;
            dgvSnackUser.DataSource = null;

            ShowRepastsUser(dgvBreakfastUser, "Breakfasts", 30, "breakfasts");
            ShowRepastsUser(dgvLunchUser, "Lunches", 30, "lunches");
            ShowRepastsUser(dgvDinnerUser, "Dinners", 30, "dinners");
            ShowRepastsUser(dgvSnackUser, "Snacks", 30, "snacks");
        }

        private void btnWeeklyAllUser_Click(object sender, EventArgs e)
        {
            dgvBreakfastAllUser.DataSource = null;
            dgvLunchAllUser.DataSource = null;
            dgvDinnerAllUser.DataSource = null;
            dgvSnackAllUser.DataSource = null;

            ShowRepastsAllUser(dgvBreakfastAllUser, "Breakfasts", 7, "breakfasts");
            ShowRepastsAllUser(dgvLunchAllUser, "Lunches", 7, "lunches");
            ShowRepastsAllUser(dgvDinnerAllUser, "Dinners", 7, "dinners");
            ShowRepastsAllUser(dgvSnackAllUser, "Snacks", 7, "snacks");
        }

        private void btnMonthlyAllUser_Click(object sender, EventArgs e)
        {
            dgvBreakfastAllUser.DataSource = null;
            dgvLunchAllUser.DataSource = null;
            dgvDinnerAllUser.DataSource = null;
            dgvSnackAllUser.DataSource = null;

            ShowRepastsAllUser(dgvBreakfastAllUser, "Breakfasts", 30, "breakfasts");
            ShowRepastsAllUser(dgvLunchAllUser, "Lunches", 30, "lunches");
            ShowRepastsAllUser(dgvDinnerAllUser, "Dinners", 30, "dinners");
            ShowRepastsAllUser(dgvSnackAllUser, "Snacks", 30, "snacks");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
