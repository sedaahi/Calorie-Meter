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
    public partial class AddFoodToRepast : Form
    {
        private readonly ApplicationDbContext db;
        private readonly User user;
        private readonly DateTime repastTime;
        private readonly string code;
        private readonly RepastFoodDetail repastFoodDetailDelete;

        public AddFoodToRepast(ApplicationDbContext db, User user, DateTime repastTime, string code, RepastFoodDetail repastFoodDetailDelete)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            this.repastTime = repastTime;
            this.code = code;
            this.repastFoodDetailDelete = repastFoodDetailDelete;
            LoadPortionsAndFoods();
        }

        private void LoadPortionsAndFoods()
        {
            cboCategories.DataSource = db.Categorys.ToList();
            cboCategories.DisplayMember = "Name";
            cboCategories.ValueMember = "Id";
            cboPortion.DataSource = Enum.GetValues(typeof(Data.Enums.PortionPreference));
            nudNumber.Enabled = false;

            if (code == "updateFoodBreakfast")
            {
                btnAddToDinner.Visible = false;
                btnAddToLunch.Visible = false;
                btnAddToSnacks.Visible = false;
                btnAddNewFood.Visible = false;
                btnAddToBreakfast.Text = "Update Breakfast";
            }
            else if (code == "updateFoodLunch")
            {
                btnAddToBreakfast.Visible = false;
                btnAddToDinner.Visible = false;
                btnAddToSnacks.Visible = false;
                btnAddNewFood.Visible = false;
                btnAddToLunch.Text = "Update Lunch";
            }
            else if (code == "updateFoodDinner")
            {
                btnAddToBreakfast.Visible = false;
                btnAddToLunch.Visible = false;
                btnAddToSnacks.Visible = false;
                btnAddNewFood.Visible = false;
                btnAddToDinner.Text = "Update Dinner";
            }
            else if (code == "updateFoodSnack")
            {
                btnAddToDinner.Visible = false;
                btnAddToLunch.Visible = false;
                btnAddToBreakfast.Visible = false;
                btnAddNewFood.Visible = false;
                btnAddToSnacks.Text = "Update Snack";
            }
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Food> foods = ((Category)cboCategories.SelectedItem).Foods.ToList();
            dgvFoods.DataSource = foods.ToList();
            dgvFoods.Columns["Id"].Visible = false;
            dgvFoods.Columns["ImagePath"].Visible = false;
            dgvFoods.Columns["CountOfTotalEating"].Visible = false;
            dgvFoods.Columns["CountOfEatingBreakfeast"].Visible = false;
            dgvFoods.Columns["CountOfEatingLunch"].Visible = false;
            dgvFoods.Columns["CountOfEatingDinner"].Visible = false;
            dgvFoods.Columns["CountOfEatingSnack"].Visible = false;
            dgvFoods.Columns["CategoriId"].Visible = false;
            dgvFoods.Columns["Category"].Visible = false;
            dgvFoods.Columns["RepastFoodDetails"].Visible = false;

        }

        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count == 0)
            {
                return;
            }

            Food food = (Food)dgvFoods.SelectedRows[0].DataBoundItem;
            pbFoodPicture.ImageLocation = food.ImagePath;
            pbFoodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AddFood(Food addFood, string repastName, Data.Enums.RepastName repastNameEnum, Data.Enums.PortionPreference portionPreference, double portionFactorAdd)
        {
            if (code == "addFood")
            {
                if (!user.Repasts.Any(x => x.Name == $"{repastName} {repastTime.Date}"))
                {
                    if (nudNumber.Enabled == false)
                    {
                        nudNumber.Value = 1;
                    }
                    Repast repastAdd = new Repast()
                    {
                        Name = $"{repastName} {repastTime.Date}",
                        RepastName = repastNameEnum,
                        Date = repastTime.Date,
                        User = user
                    };
                    RepastFoodDetail repastFoodDetailAdd = new RepastFoodDetail()
                    {
                        Food = addFood,
                        Repast = repastAdd,
                        Number = (int)nudNumber.Value,
                        Portion = portionPreference
                    };

                    PortionAdd(addFood, portionFactorAdd, repastFoodDetailAdd, repastAdd, repastName);
                    db.Repasts.Add(repastAdd);
                    db.RepastFoodDetails.Add(repastFoodDetailAdd);
                    if (portionPreference == Data.Enums.PortionPreference.OneAndHalf)
                    {
                        MessageBox.Show($"One and half portion {addFood.Name} added to {repastName} repasts.");
                    }
                    else if (portionPreference == Data.Enums.PortionPreference.Half)
                    {
                        MessageBox.Show($"Half portion {addFood.Name} added to {repastName} repasts.");
                    }
                    else
                    {
                        MessageBox.Show($"{nudNumber.Value.ToString()} {addFood.Name} added to {repastName} repasts.");
                    }
                    db.SaveChanges();
                    nudNumber.Value = 1;
                }
                else
                {
                    Repast repast = user.Repasts.FirstOrDefault(x => x.Name == $"{repastName} {repastTime.Date}");
                    RepastFoodDetail repastFoodDetailAdd = new RepastFoodDetail()
                    {
                        Food = addFood,
                        Repast = repast,
                        Number = (int)nudNumber.Value,
                        Portion = portionPreference
                    };

                    PortionAdd(addFood, portionFactorAdd, repastFoodDetailAdd, repast, repastName);
                    db.RepastFoodDetails.Add(repastFoodDetailAdd);
                    if (portionPreference == Data.Enums.PortionPreference.OneAndHalf)
                    {
                        MessageBox.Show($"One and half portion {addFood.Name} added to {repastName} repasts.");
                    }
                    else if (portionPreference == Data.Enums.PortionPreference.Half)
                    {
                        MessageBox.Show($"Half portion {addFood.Name} added to {repastName} repasts.");
                    }
                    else
                    {
                        MessageBox.Show($"{nudNumber.Value.ToString()} {addFood.Name} added to {repastName} repasts.");
                    }
                    db.SaveChanges();
                    nudNumber.Value = 1;
                }
            }
            else
            {

                Repast repastAdd = (Repast)user.Repasts.FirstOrDefault(x => x.Name == $"{repastName} {repastTime.Date}");

                RepastFoodDetail repastFoodDetailAdd = new RepastFoodDetail()
                {
                    Food = addFood,
                    Repast = repastAdd,
                    Number = (int)nudNumber.Value,
                    Portion = portionPreference
                };


                double portionFactorDelete = 0;
                if (repastFoodDetailDelete.Portion == Data.Enums.PortionPreference.Half)
                    portionFactorDelete = 0.5;
                else if (repastFoodDetailDelete.Portion == Data.Enums.PortionPreference.Full)
                    portionFactorDelete = 1;
                else if (repastFoodDetailDelete.Portion == Data.Enums.PortionPreference.OneAndHalf)
                    portionFactorDelete = 1.5;

                CalorieDelete(repastFoodDetailDelete.Food, portionFactorDelete, repastFoodDetailDelete, repastFoodDetailDelete.Repast, repastName);
                PortionAdd(addFood, portionFactorAdd, repastFoodDetailAdd, repastAdd, repastName);

                db.RepastFoodDetails.Remove(repastFoodDetailDelete);
                db.RepastFoodDetails.Add(repastFoodDetailAdd);
                if (portionPreference == Data.Enums.PortionPreference.OneAndHalf)
                {
                    MessageBox.Show($"One and half portion {addFood.Name} added to {repastName} repasts.");
                }
                else if (portionPreference == Data.Enums.PortionPreference.Half)
                {
                    MessageBox.Show($"Half portion {addFood.Name} added to {repastName} repasts.");
                }
                else
                {
                    MessageBox.Show($"{nudNumber.Value.ToString()} {addFood.Name} added to {repastName} repasts.");
                }
                db.SaveChanges();
                Close();
            }
        }

        private void PortionAdd(Food addFood, double portionFactorAdd, RepastFoodDetail repastFoodDetailAdd, Repast repastAdd, string repastName)
        {
            if (repastName =="Snacks")
            {
                addFood.CountOfEatingSnack += repastFoodDetailAdd.Number;
            }
            else if (repastName == "Dinners")
            {
                addFood.CountOfEatingDinner += repastFoodDetailAdd.Number;
            }
            else if (repastName == "Lunches")
            {
                addFood.CountOfEatingLunch += repastFoodDetailAdd.Number;
            }
            else if (repastName == "Breakfasts")
            {
                addFood.CountOfEatingBreakfeast += repastFoodDetailAdd.Number;
            }

            addFood.CountOfTotalEating += repastFoodDetailAdd.Number;

            repastFoodDetailAdd.TotalProteinDetail += Math.Round((addFood.Protein * portionFactorAdd * repastFoodDetailAdd.Number), 2);
            repastFoodDetailAdd.TotalCalorieDetail += Math.Round((addFood.Calorie * portionFactorAdd * repastFoodDetailAdd.Number), 2);
            repastFoodDetailAdd.TotalFatDetail += Math.Round((addFood.Fat * portionFactorAdd * repastFoodDetailAdd.Number), 2);
            repastFoodDetailAdd.TotalCarboHydrateDetail += Math.Round((addFood.CarboHydrate * portionFactorAdd * repastFoodDetailAdd.Number), 2);

            repastAdd.TotalProteinRepast += Math.Round((addFood.Protein * portionFactorAdd * repastFoodDetailAdd.Number), 2);
            repastAdd.TotalFatRepast += Math.Round((addFood.Fat * portionFactorAdd * repastFoodDetailAdd.Number), 2);
            repastAdd.TotalCarboHydrateRepast += Math.Round((addFood.CarboHydrate * portionFactorAdd * repastFoodDetailAdd.Number), 2);
            repastAdd.TotalCalorieRepast += Math.Round((addFood.Calorie * portionFactorAdd * repastFoodDetailAdd.Number), 2);

        }

        private void CalorieDelete(Food deletedFood, double portionFactorDelete, RepastFoodDetail repastFoodDetailDelete, Repast repastDelete, string repastName)
        {
            if (repastName == "Snacks")
            {
                deletedFood.CountOfEatingSnack -= repastFoodDetailDelete.Number;
            }
            else if (repastName == "Dinners")
            {
                deletedFood.CountOfEatingDinner -= repastFoodDetailDelete.Number;
            }
            else if (repastName == "Lunches")
            {
                deletedFood.CountOfEatingLunch -= repastFoodDetailDelete.Number;
            }
            else if (repastName == "Breakfasts")
            {
                deletedFood.CountOfEatingBreakfeast -= repastFoodDetailDelete.Number;
            }
            deletedFood.CountOfTotalEating -= repastFoodDetailDelete.Number;

            repastFoodDetailDelete.TotalProteinDetail -= Math.Round((deletedFood.Protein * portionFactorDelete * repastFoodDetailDelete.Number), 2);
            repastFoodDetailDelete.TotalCalorieDetail -= Math.Round((deletedFood.Calorie * portionFactorDelete * repastFoodDetailDelete.Number), 2);
            repastFoodDetailDelete.TotalFatDetail -= Math.Round((deletedFood.Fat * portionFactorDelete * repastFoodDetailDelete.Number), 2);
            repastFoodDetailDelete.TotalCarboHydrateDetail -= Math.Round((deletedFood.CarboHydrate * portionFactorDelete * repastFoodDetailDelete.Number), 2);

            repastDelete.TotalProteinRepast -= Math.Round((deletedFood.Protein * portionFactorDelete * repastFoodDetailDelete.Number), 2);
            repastDelete.TotalFatRepast -= Math.Round((deletedFood.Fat * portionFactorDelete * repastFoodDetailDelete.Number), 2);
            repastDelete.TotalCarboHydrateRepast -= Math.Round((deletedFood.CarboHydrate * portionFactorDelete * repastFoodDetailDelete.Number), 2);
            repastDelete.TotalCalorieRepast -= Math.Round((deletedFood.Calorie * portionFactorDelete * repastFoodDetailDelete.Number), 2);

        }

        private void btnAddToSnacks_Click(object sender, EventArgs e)
        {
            Food addFood = (Food)dgvFoods.SelectedRows[0].DataBoundItem;

            double portionFactor;

            if (cboPortion.SelectedIndex == 0)
            {
                portionFactor = 0.5;
                AddFood(addFood, "Snacks", Data.Enums.RepastName.Snacks, Data.Enums.PortionPreference.Half, portionFactor);

            }
            else if (cboPortion.SelectedIndex == 1)
            {
                portionFactor = 1;
                AddFood(addFood, "Snacks", Data.Enums.RepastName.Snacks, Data.Enums.PortionPreference.Full, portionFactor);

            }
            else
            {
                portionFactor = 1.5;
                AddFood(addFood, "Snacks", Data.Enums.RepastName.Snacks, Data.Enums.PortionPreference.OneAndHalf, portionFactor);
            }

        }

        private void btnAddToDinner_Click(object sender, EventArgs e)
        {
            Food addFood = (Food)dgvFoods.SelectedRows[0].DataBoundItem;

            double portionAdd;

            if (cboPortion.SelectedIndex == 0)
            {
                portionAdd = 0.5;
                AddFood(addFood, "Dinners", Data.Enums.RepastName.Dinner, Data.Enums.PortionPreference.Half, portionAdd);

            }
            else if (cboPortion.SelectedIndex == 1)
            {
                portionAdd = 1;
                AddFood(addFood, "Dinners", Data.Enums.RepastName.Dinner, Data.Enums.PortionPreference.Full, portionAdd);

            }
            else
            {
                portionAdd = 1.5;
                AddFood(addFood, "Dinners", Data.Enums.RepastName.Dinner, Data.Enums.PortionPreference.OneAndHalf, portionAdd);

            }

        }

        private void btnAddToLunch_Click(object sender, EventArgs e)
        {
            Food addFood = (Food)dgvFoods.SelectedRows[0].DataBoundItem;

            double portionAdd;

            if (cboPortion.SelectedIndex == 0)
            {
                portionAdd = 0.5;
                AddFood(addFood, "Lunches", Data.Enums.RepastName.Lunch, Data.Enums.PortionPreference.Half, portionAdd);

            }
            else if (cboPortion.SelectedIndex == 1)
            {
                portionAdd = 1;
                AddFood(addFood, "Lunches", Data.Enums.RepastName.Lunch, Data.Enums.PortionPreference.Full, portionAdd);

            }
            else
            {
                portionAdd = 1.5;
                AddFood(addFood, "Lunches", Data.Enums.RepastName.Lunch, Data.Enums.PortionPreference.OneAndHalf, portionAdd);
            }

        }

        private void btnAddToBreakfast_Click(object sender, EventArgs e)
        {
            Food addFood = (Food)dgvFoods.SelectedRows[0].DataBoundItem;

            double portionAdd;

            if (cboPortion.SelectedIndex == 0)
            {
                portionAdd = 0.5;
                AddFood(addFood, "Breakfasts", Data.Enums.RepastName.Breakfast, Data.Enums.PortionPreference.Half, portionAdd);

            }
            else if (cboPortion.SelectedIndex == 1)
            {
                portionAdd = 1;
                AddFood(addFood, "Breakfasts", Data.Enums.RepastName.Breakfast, Data.Enums.PortionPreference.Full, portionAdd);

            }
            else
            {
                portionAdd = 1.5;
                AddFood(addFood, "Breakfasts", Data.Enums.RepastName.Breakfast, Data.Enums.PortionPreference.OneAndHalf, portionAdd);

            }

        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            AddNewFood addNewFood = new AddNewFood(db);
            this.Hide();
            addNewFood.ShowDialog();
            this.Show();
            LoadPortionsAndFoods();
        }

        private void cboPortion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPortion.SelectedIndex == 1)
            {
                nudNumber.Enabled = true;
            }
            else
            {
                nudNumber.Enabled = false;
            }
        }
    }
}
