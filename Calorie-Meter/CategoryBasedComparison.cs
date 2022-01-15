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
    public partial class CategoryBasedComparison : Form
    {
        private readonly ApplicationDbContext db;
        private readonly User user;

        public CategoryBasedComparison(ApplicationDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            LoadCategoriesAndWeeklyMonthly();
        }

        private void LoadCategoriesAndWeeklyMonthly()
        {
            cboCategoryUser.DataSource = db.Categorys.ToList();
            cboCategoryUser.DisplayMember = "Name";
            cboWeeklyMonthlyUser.DataSource = Enum.GetValues(typeof(Enums.WeeklyMonthly));
            
            cboCategoryAllUsers.DataSource = db.Categorys.ToList();
            cboCategoryAllUsers.DisplayMember = "Name";
            cboWeeklyMonthlyAllUsers.DataSource = Enum.GetValues(typeof(Enums.WeeklyMonthly));
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            Category category = (Category)cboCategoryUser.SelectedItem;
            
            int dateTime = 0;
            
            if (cboWeeklyMonthlyUser.SelectedIndex == 0)
                dateTime = 7;
            else
                dateTime = 30;
            
            var passTime = DateTime.Now.AddDays(-dateTime);
            var nowTime = DateTime.Now.Date;
            
            List<Repast> userRepasts = user.Repasts
                .Where(x => x.Date <= nowTime && x.Date >= passTime)
                .ToList();
            
            List<RepastFoodDetail> userRepastFoodDetail = new List<RepastFoodDetail>();

            foreach (var item in userRepasts)
            {
                foreach (var item2 in item.RepastFoodDetails)
                {
                    userRepastFoodDetail.Add(item2);
                }
            }
            
            dgvUser.DataSource = userRepastFoodDetail.Where(b => b.Food.CategoriId == category.Id).GroupBy(x => x.Food.Name).Select(y => new
            {
                Name = y.Key,
                Count = y.Sum(s => s.Number)
            }).OrderByDescending(z => z.Count).ToList();
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            Category category = (Category)cboCategoryAllUsers.SelectedItem;

            int dateTime = 0;

            if (cboWeeklyMonthlyAllUsers.SelectedIndex == 0)
                dateTime = 7;
            else
                dateTime = 30;

            var passTime = DateTime.Now.AddDays(-dateTime);
            var nowTime = DateTime.Now.Date;

            List<RepastFoodDetail> repastFoodDetails = db.RepastFoodDetails
                .Where(x => x.Repast.Date <= nowTime && x.Repast.Date >= passTime && x.Food.CategoriId == category.Id)
                .ToList();

            dgvAllUsers.DataSource = repastFoodDetails.Where(b => b.Food.CategoriId == category.Id).GroupBy(x => x.Food.Name).Select(y => new
            {
                Name = y.Key,
                Count = y.Sum(s => s.Number)
            }).OrderByDescending(z => z.Count).ToList();

        }

        private void btnExitUser_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExitAllUsers_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
