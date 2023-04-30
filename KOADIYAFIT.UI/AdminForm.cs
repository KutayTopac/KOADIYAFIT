using KOADIYAFIT.DAL.Context;
using KOADIYAFIT.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace KOADIYAFIT.UI
{
    public partial class AdminForm : Form
    {
        private List<MealType> mealTypes;
        private string addFoodSelectedImagePath { get; set; } = string.Empty;
        private string updatedFoodSelectedImagePath { get; set; } = string.Empty;
        private string addMealSelectedImagePath { get; set; } = string.Empty;

        public AdminForm()
        {

            InitializeComponent();
        }

        private void GetMealTypes()
        {
            using (var db = new ProjectContext())
            {
                mealTypes = db.MealTypes.ToList();

            }
            cmbAddFoodMealType.Items.Clear();
            cmbUpdatedMealType.Items.Clear();
            cmbDeletedMeal.Items.Clear();
            foreach (var mealType in mealTypes)
            {
                cmbAddFoodMealType.Items.Add(mealType);
                cmbUpdatedMealType.Items.Add(mealType.MealTypeName);
                cmbDeletedMeal.Items.Add(mealType.MealTypeName);
            }
        }

        private void GetFoods()
        {
            using (var db = new ProjectContext())
            {
                var tumYiyecekler = db.Foods.OrderBy(x => x.FoodName).ToList();
                if (cmbSilinecekUrun.Items.Count > 0)
                    cmbSilinecekUrun.Items.Clear();
                tumYiyecekler.ForEach(x => cmbSilinecekUrun.Items.Add(x.FoodName));

                if (tumYiyecekler.Count > 0)
                    cmbSilinecekUrun.SelectedIndex = -1;

                var allFoods = db.Foods.OrderBy(x => x.FoodName).ToList();
                if (cmbUpdatedProduct.Items.Count > 0)
                    cmbUpdatedProduct.Items.Clear();
                allFoods.ForEach(x => cmbUpdatedProduct.Items.Add(x.FoodName));
                if (allFoods.Count > 0)
                    cmbUpdatedProduct.SelectedIndex = -1;

            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbSilinecekUrun.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçiniz.");
                return;
            }
            using (var db = new ProjectContext())
            {
                var deleted = db.Foods.Where(x => x.FoodName == cmbSilinecekUrun.Text).ToList();
                db.Foods.RemoveRange(deleted);
                MessageBox.Show("Ürün Silinmiştir");
                db.SaveChanges();
            }
            GetFoods();
        }

        private void button2_Click(object sender, EventArgs e)//Add food button
        {
            if (string.IsNullOrEmpty(addFoodSelectedImagePath))
            {
                MessageBox.Show("Lütfen yemek görseli seçin.");
                return;
            }


            using (var db = new ProjectContext())
            {
                try
                {
                    var food = new Food()
                    {
                        FoodName = txtAddFoodName.Text,
                        PortionSize = txtPortionSize.Text,
                        Calorie = int.Parse(txtCalorie.Text),
                        MealTypeId = ((MealType)cmbAddFoodMealType.SelectedItem).MealTypeId,
                        FoodImage = File.ReadAllBytes(addFoodSelectedImagePath)
                    };

                    db.Foods.Add(food);
                    db.SaveChanges();
                    MessageBox.Show("Ürün başayrıyla eklenmiştir.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen alanları eksiksiz doldurunuz.");
                }

            }
            GetFoods();
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            addFoodSelectedImagePath = string.Empty;
            updatedFoodSelectedImagePath = string.Empty;
            GetMealTypes();
            GetFoods();
        }

        private void btnAddFoodSelectImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                addFoodSelectedImagePath = dialog.FileName;
                pbAddFood.Image = Image.FromFile(addFoodSelectedImagePath);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Session.MenuChoiceForm.Show();
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updatedFoodSelectedImagePath))
            {
                MessageBox.Show("Lütfen yemek görseli seçin.");
                return;
            }
            using (var db = new ProjectContext())
            {
                try
                {
                    string foodName = cmbUpdatedProduct.Text;
                    Food updatedFood = db.Foods.First(x => x.FoodName == foodName);
                    updatedFood.FoodName = txtUpdatedFoodName.Text;
                    updatedFood.MealTypeId = ((MealType)cmbUpdatedMealType.SelectedItem).MealTypeId;
                    updatedFood.PortionSize = txtUpdatedPortionSize.Text;
                    updatedFood.Calorie = int.Parse(txtUpdatedFoodCalorie.Text);
                    updatedFood.FoodImage = File.ReadAllBytes(updatedFoodSelectedImagePath);
                    db.SaveChanges();

                    MessageBox.Show("Ürün başarıyla güncellenmitir.");
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen alanları eksiksiz doldurunuz.");
                }

            }
            GetFoods();
        }

        private void bntUpdatedFoodImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                updatedFoodSelectedImagePath = dialog.FileName;
                pbUpdatedFood.Image = Image.FromFile(updatedFoodSelectedImagePath);
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchMealImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                addMealSelectedImagePath = dialog.FileName;
                pbMealType.Image = Image.FromFile(addMealSelectedImagePath);
            }
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addMealSelectedImagePath))
            {
                MessageBox.Show("Lütfen eklenecek öğün görseli seçin.");
                return;
            }


            using (var db = new ProjectContext())
            {
                if(txtMealName.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen eklenecek öğünün adını giriniz");
                    return;
                }
                var meal = new MealType()
                {
                    MealTypeName = txtMealName.Text,
                    MealTypeImage = File.ReadAllBytes(addMealSelectedImagePath)
                };

                db.MealTypes.Add(meal);
                db.SaveChanges();
                MessageBox.Show("Öğün Başarıyla Eklenmiştir.");
            }
            GetMealTypes();
        }

        private void btnDeleteMealType_Click(object sender, EventArgs e)
        {
            if (cmbDeletedMeal.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek öüğünü seçiniz.");
                return;
            }
            using (var db = new ProjectContext())
            {
                var deletedMealTypeName = cmbDeletedMeal.Text;
                var deletedMealType = db.MealTypes.Where(x => x.MealTypeName == deletedMealTypeName).First();
                db.MealTypes.Remove(deletedMealType);
                db.SaveChanges();
            }
            MessageBox.Show("Öğün Başarıyla Silinmiştir.");
            GetMealTypes();
        }
    }
}