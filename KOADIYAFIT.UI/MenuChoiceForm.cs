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

namespace KOADIYAFIT.UI
{
    public partial class MenuChoiceForm : Form
    {
        public MenuChoiceForm()
        {
            InitializeComponent();
        }

        private void AddMealIntoLayoutPanel(MealType mealType)
        {
            var mealItemPanel = new Panel()
            {
                Size = new Size
                {
                    Width = 280,
                    Height = 500
                },
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle
            };
            var mealImage = new PictureBox()
            {
                Size = new Size
                {
                    Width = 278,
                    Height = 440
                },
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = Image.FromStream(new MemoryStream(mealType.MealTypeImage))
            };
            mealItemPanel.Controls.Add(mealImage);

            var mealName = new Label()
            {
                Text = mealType.MealTypeName,
                Size = new Size()
                {
                    Width = 150,
                    Height = 45
                },
                Top = 440,

                Font = new Font("Gabriola", 20),
                BackColor = Color.Black,
                ForeColor = Color.White
            };

            var mealTypeButton = new Button()
            {
                Text = "Öğüne Git",
                Tag = mealType.MealTypeId,
                Size = new Size() { Width = 110, Height = 50 },
                BackColor = Color.Black,
                ForeColor = Color.White,
                Font = new Font("Gabriola", 17),
                Left = 165,
                Top = 440,
                Cursor = Cursors.Hand
            };
            mealTypeButton.Click += MealTypeButton_Click;
            mealItemPanel.Controls.Add(mealTypeButton);
            mealItemPanel.Controls.Add(mealName);
            flpMealType.Controls.Add(mealItemPanel);

        }

        private void MealTypeButton_Click(object? sender, EventArgs e)
        {
            if (sender == null) { return; }

            var btn = sender as Button;
            if (btn == null || btn.Tag == null) { return; }

            var mealTypeId = (int)btn.Tag;
            Session.FoodSelectForm.SelectedMealTypeId = mealTypeId;
            this.Hide();
            Session.FoodSelectForm.Show();
            Session.FoodSelectForm.InitData();
        }

        private void TestMenuChoiceForm_Shown(object sender, EventArgs e) 
        {
            using (var db = new ProjectContext())
            {
                var meals = db.MealTypes.ToList();
                foreach (var meal in meals)
                {
                    AddMealIntoLayoutPanel(meal);
                }
            }
        }

        private void MenuChoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
