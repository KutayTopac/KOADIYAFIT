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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ProjectContext())
                {
                    if (txtParola.Text != txtParolaTekrar.Text)
                    {
                        MessageBox.Show("Girmiş olduğunuz parolalar uyuşmamaktadır.");
                        return;
                    }

                    if (cmbDiyabetTipi.SelectedItem == null)
                    {
                        MessageBox.Show("Lütfen diyabet tipi seçiniz.");
                        return;
                    }

                    User user = new User()
                    {
                        UserName = txtKullaniciAdi.Text,
                        EMail = txtEmail.Text,
                        Weight = int.Parse(txtKilo.Text),
                        Password = txtParola.Text,
                        Age = int.Parse(txtYas.Text),
                        DiabetType = (string)cmbDiyabetTipi.SelectedItem,
                        Height = int.Parse(txtBoy.Text)
                    };

                    double bodyMassIndex = user.Weight / Math.Pow(user.Height / 100.0f, 2);
                    user.BMI = bodyMassIndex;
                    if (bodyMassIndex >= 0 && bodyMassIndex < 18.5)
                        user.WeightStatus = "Zayıf";
                    else if (bodyMassIndex >= 18.5 && bodyMassIndex < 25)
                        user.WeightStatus = "Normal";
                    else if (bodyMassIndex >= 25 && bodyMassIndex < 30)
                        user.WeightStatus = "Fazla Kilolu";
                    else if (bodyMassIndex >= 30 && bodyMassIndex < 45)
                        user.WeightStatus = "Şişman";
                    else
                        user.WeightStatus = "Aşırı Şişman";
                                                          
                    

                    db.Users.Add(user);
                    db.SaveChanges();
                    Session.CurrentUser = user;

                    MessageBox.Show("Kayıt başarılı..", "Kullanıcı Kayıt", MessageBoxButtons.OK);
                    this.Hide();
                    Session.MenuChoiceForm.Show();

                    GetClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alanlar boş bırakılamaz veya yanlış değer girdiniz.");
            }
        }

        private void GetClear()
        {
            txtBoy.Text = txtEmail.Text = txtKilo.Text = txtKullaniciAdi.Text = txtParola.Text = txtParolaTekrar.Text = txtYas.Text = "";
            cmbDiyabetTipi.SelectedIndex = -1;
        }

        private void KayıtFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Session.MainForm.Show();
        }
    }
}
