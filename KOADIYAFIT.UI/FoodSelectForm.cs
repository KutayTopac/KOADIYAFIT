using KOADIYAFIT.DAL.Context;
using KOADIYAFIT.DATA.Entities;
using KOADIYAFIT.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOADIYAFIT
{
    public partial class FoodSelectForm : Form
    {
        public int foodId;
        public int SelectedMealTypeId;
        private Dictionary<int, int> foodPortions = new Dictionary<int, int>();
        private int totalCalorie = 0;
        private int limitCalorie = 800;

        public FoodSelectForm()
        {
            InitializeComponent();

        }

        private void KahvaltiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOgunSecimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session.MenuChoiceForm.Show();
        }

        public void InitData()
        {
            using (var db = new ProjectContext())
            {
                var foods = db.Foods.Where(x => x.MealTypeId == SelectedMealTypeId).ToList();
                flpFoods.Controls.Clear();

                foreach (var food in foods)
                {
                    AddFoodIntoLayout(food);
                }

            }
            var userWeightStatus = Session.CurrentUser.WeightStatus;
            if (userWeightStatus == "Zayıf")
                limitCalorie = 1000;
            else if (userWeightStatus == "Fazla Kilolu")
                limitCalorie = 600;
            else if (userWeightStatus == "Şişman")
                limitCalorie = 550;
            else if (userWeightStatus == "Aşırı Şişman")
                limitCalorie = 500;
            GetUserMeals();
        }
        private void GetUserMeals()
        {
            using (var db = new ProjectContext())
            {
                var meals = db.UserMeals.Include(x => x.Food).Where(x => x.UserId == Session.CurrentUser.Id && x.CreatedDate == DateTime.Now.Date && x.Food.MealTypeId == SelectedMealTypeId);

                lstKahvalti.Items.Clear();
                totalCalorie = 0;
                foreach (var meal in meals)
                {
                    var lvi = new ListViewItem();
                    lvi.Text = meal.Food.FoodName;
                    lvi.SubItems.Add(meal.Food.PortionSize);
                    lvi.SubItems.Add(Convert.ToString(meal.Portion));
                    lvi.SubItems.Add(Convert.ToString(meal.Food.Calorie * meal.Portion));

                    lstKahvalti.Items.Add(lvi);
                    totalCalorie += meal.Food.Calorie * meal.Portion;
                }
            }
        }

        private void AddFoodIntoLayout(Food food)
        {
            var foodItemPanel = new Panel()
            {
                Size = new Size
                {
                    Width = 125,
                    Height = 150
                },
                BorderStyle = BorderStyle.FixedSingle
            };

            var foodImage = new PictureBox()
            {
                Size = new Size
                {
                    Width = 125,
                    Height = 105
                },
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = Image.FromStream(new MemoryStream(food.FoodImage))
            };
            foodItemPanel.Controls.Add(foodImage);

            var foodName = new Label()
            {
                Text = food.FoodName,
                Size = new Size
                {
                    Width = 125,
                    Height = 15
                },
                Top = 105
            };
            foodItemPanel.Controls.Add(foodName);

            var foodActionPanel = new Panel()
            {
                Size = new Size
                {
                    Width = 125,
                    Height = 30
                },
                Top = 120
            };
            var foodActionNumeric = new NumericUpDown()
            {
                Name = $"nud-food-portion-{food.FoodId}",
                Tag = food.FoodId,
                Size = new Size
                {
                    Width = 90,
                    Height = 30
                },
                Value = 1,
                Minimum = 1
            };
            foodActionNumeric.ValueChanged += FoodActionNumeric_ValueChanged;
            foodActionPanel.Controls.Add(foodActionNumeric);

            var foodActionButton = new Button()
            {
                Name = $"btn-food-ok-{food.FoodId}",
                Tag = food.FoodId,
                Text = "OK",
                Size = new Size
                {
                    Width = 30,
                    Height = 30
                },
                Left = 90
            };
            foodActionButton.Click += FoodActionButton_Click;
            foodActionPanel.Controls.Add(foodActionButton);

            foodItemPanel.Controls.Add(foodActionPanel);

            //
            flpFoods.Controls.Add(foodItemPanel);
        }

        private void FoodActionNumeric_ValueChanged(object? sender, EventArgs e)
        {
            if (sender == null) { return; }

            var nud = sender as NumericUpDown;
            if (nud == null || nud.Tag == null) { return; }

            var foodId = (int)nud.Tag;

            if (foodPortions.Keys.Any(k => k == foodId))
            {
                foodPortions.Remove(foodId);
            }

            foodPortions.Add(foodId, (int)nud.Value);
        }

        private void FoodActionButton_Click(object? sender, EventArgs e)
        {
            if (sender == null) { return; }

            var btn = sender as Button;
            if (btn == null || btn.Tag == null) { return; }

            var foodId = (int)btn.Tag;

            foodPortions.TryGetValue(foodId, out var portion);
            if (portion == 0) { portion = 1; } // user did not touch the portion input. then set it to 1 portion as default.


            using (var db = new ProjectContext())
            {
                var food = db.Foods.Find(foodId);
                if (food == null) { return; }

                totalCalorie += food.Calorie * portion;
                var userWeightStatus = Session.CurrentUser.WeightStatus;
                if (userWeightStatus == "Zayıf")
                {

                    if (totalCalorie > limitCalorie)
                    {
                        MessageBox.Show("Kahvaltı için size önerilen kalori limitini aştınız!! Lütfen Kahvaltı öğününüzü düzenleyiniz");
                        totalCalorie -= food.Calorie * portion;
                        return;
                    }
                }
                else if (userWeightStatus == "Normal")
                {
                    if (totalCalorie > limitCalorie)
                    {
                        MessageBox.Show("Kahvaltı için size önerilen kalori limitini aştınız!! Lütfen Kahvaltı öğününüzü düzenleyiniz");
                        totalCalorie -= food.Calorie * portion;
                        return;
                    }
                }
                else if (userWeightStatus == "Fazla Kilolu")
                {

                    if (totalCalorie > limitCalorie)
                    {
                        MessageBox.Show("Kahvaltı için size önerilen kalori limitini aştınız!! Lütfen Kahvaltı öğününüzü düzenleyiniz");
                        totalCalorie -= food.Calorie * portion;
                        return;
                    }
                }
                else if (userWeightStatus == "Şişman")
                {

                    if (totalCalorie > limitCalorie)
                    {
                        MessageBox.Show("Kahvaltı için size önerilen kalori limitini aştınız!! Lütfen Kahvaltı öğününüzü düzenleyiniz");
                        totalCalorie -= food.Calorie * portion;
                        return;
                    }
                }
                else if (userWeightStatus == "Aşırı Şişman")
                {

                    if (totalCalorie > limitCalorie)
                    {
                        MessageBox.Show("Kahvaltı için size önerilen kalori limitini aştınız!! Lütfen Kahvaltı öğününüzü düzenleyiniz");
                        totalCalorie -= food.Calorie * portion;
                        return;
                    }
                }
                var userMeal = db.UserMeals.Where(x => x.UserId == Session.CurrentUser.Id && x.FoodId == foodId && x.CreatedDate == DateTime.Now.Date).FirstOrDefault();
                if (userMeal != null)
                {
                    userMeal.Portion += portion;
                    userMeal.TotalCalorie = userMeal.Portion * food.Calorie;
                }
                else
                {
                    db.UserMeals.Add(new UserMeal()
                    {
                        CreatedDate = DateTime.Now.Date,
                        TotalCalorie = food.Calorie * portion,
                        UserId = Session.CurrentUser.Id,
                        FoodId = foodId,

                        Portion = portion
                    });
                }
                db.SaveChanges();
                GetUserMeals();
            };
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            using (var db = new ProjectContext())
            {
                try
                {
                    var totalCalorie1 = lstKahvalti.SelectedItems[0].SubItems[3].Text.ToString();

                    var calorie = db.UserMeals.FirstOrDefault(x => x.TotalCalorie == Convert.ToInt32(totalCalorie1));
                    totalCalorie -= Convert.ToInt32(totalCalorie1);

                    db.UserMeals.Remove(calorie);
                    db.SaveChanges();
                    lstKahvalti.Items.Remove(lstKahvalti.SelectedItems[0]);
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen silinecek ürünü seçiniz.");
                }


            }
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session.RaporForm.InitData();
            Session.RaporForm.Show();
        }
    }
}
