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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }
        public void InitData()
        {
            cmbMealTypeView.Items.Clear();
            using (var db = new ProjectContext())
            {
                var mealTypes = db.MealTypes.ToList();
                foreach (var mealType in mealTypes)
                {
                    cmbMealTypeView.Items.Add(mealType);
                }
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            using (var db = new ProjectContext())
            {
                if(cmbMealTypeView.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen görüntülemek istediğiniz öğün tipini seçiniz.");
                    return;
                }
                var id = Session.CurrentUser.Id;
                var rapor = db.UserMeals.Where(x => x.UserId == id && x.CreatedDate == dtCreatedTime.Value.Date && x.Food.MealTypeId == ((MealType)cmbMealTypeView.SelectedItem).MealTypeId).Select(x => new
                {
                    Kullanıcı = x.User.UserName,
                    Yemek = x.Food.FoodName,
                    Porsiyon = x.Portion,
                    Kalori = x.TotalCalorie
                }).ToList();


                dgvRapor.DataSource = rapor;
                dgvRapor.Refresh();

            }
        }



        private void RaporForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOgunSecimi_Click(object sender, EventArgs e)
        {

            this.Hide();
            Session.MenuChoiceForm.Show();

        }

        private void btnPersonalNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session.PersonalNotesForm.Show();
        }
    }
}
