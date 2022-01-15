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
    public partial class EndOfDayReport : Form
    {
        private readonly ApplicationDbContext db;
        private readonly User user;
        private readonly DateTime repastTime;

        public EndOfDayReport(ApplicationDbContext db, User user, DateTime repastTime)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            this.repastTime = repastTime;
            ShowReport();
        }

        private void ShowReport()
        {
            int idBreakfast = 0;
            int idLunch = 0;
            int idDinner = 0;
            int idSnack = 0;

            if (user.Repasts.FirstOrDefault(x => x.Name == $"Breakfasts {repastTime.Date}") == null)
                lblBreakfast.Text = "0";
            else
            {
                idBreakfast = user.Repasts.FirstOrDefault(x => x.Name == $"Breakfasts {repastTime.Date}").Id;
                List<RepastFoodDetail> repastFoodDetailBreakfasts = db.RepastFoodDetails.Where(x => x.RepastId == idBreakfast).ToList();
                double totalCalorieBreakfast = Math.Round((repastFoodDetailBreakfasts.Sum(x => x.TotalCalorieDetail)), 2);
                lblBreakfast.Text = totalCalorieBreakfast.ToString();
            }

            if (user.Repasts.FirstOrDefault(x => x.Name == $"Lunches {repastTime.Date}") == null)
                lblLunch.Text = "0";
            else
            {
                idLunch = user.Repasts.FirstOrDefault(x => x.Name == $"Lunches {repastTime.Date}").Id;
                List<RepastFoodDetail> repastFoodDetailLunches = db.RepastFoodDetails.Where(x => x.RepastId == idLunch).ToList();
                double totalCalorieLunch = Math.Round((repastFoodDetailLunches.Sum(x => x.TotalCalorieDetail)), 2);
                lblLunch.Text = totalCalorieLunch.ToString();
            }

            if (user.Repasts.FirstOrDefault(x => x.Name == $"Dinners {repastTime.Date}") == null)
                lblDinner.Text = "0";
            else
            {
                idDinner = user.Repasts.FirstOrDefault(x => x.Name == $"Dinners {repastTime.Date}").Id;
                List<RepastFoodDetail> repastFoodDetailDinners = db.RepastFoodDetails.Where(x => x.RepastId == idDinner).ToList();
                double totalCalorieDinner = Math.Round((repastFoodDetailDinners.Sum(x => x.TotalCalorieDetail)), 2);
                lblDinner.Text = totalCalorieDinner.ToString();
            }

            if (user.Repasts.FirstOrDefault(x => x.Name == $"Snacks {repastTime.Date}") == null)
                lblSnacks.Text = "0";
            else
            {
                idSnack = user.Repasts.FirstOrDefault(x => x.Name == $"Snacks {repastTime.Date}").Id;
                List<RepastFoodDetail> repastFoodDetailSnacks = db.RepastFoodDetails.Where(x => x.RepastId == idSnack).ToList();
                double totalCalorieSnack = Math.Round((repastFoodDetailSnacks.Sum(x => x.TotalCalorieDetail)), 2);
                lblSnacks.Text = totalCalorieSnack.ToString();
            }

            List<Repast> repasts = user.Repasts.Where(x => x.Date == repastTime.Date).ToList();

            double totalCalorie = Math.Round((repasts.Sum(x => x.TotalCalorieRepast)),2);
            lblTotal.Text = totalCalorie.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
