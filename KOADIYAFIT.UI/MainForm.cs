using KOADIYAFIT.DAL.Context;
using KOADIYAFIT.DATA.Entities;
using KOADIYAFIT.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOADIYAFIT
{
    public partial class MainForm : Form
    {
        public List<string> allMotivationWords = new List<string>();
        public int wordNumber;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Session.RegisterForm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ProjectContext())
                {
                    var user = db.Users.FirstOrDefault(x => x.UserName == txtKullaniciAdiGiris.Text && x.Password == txtParolaGiris.Text);

                    if (user == null)
                    {
                        MessageBox.Show("Kullanıcı adı ile şifre uyuşmamaktadır.");
                        return;
                    }
                    Session.CurrentUser = user;
                    if (user.MemberType != "Admin")
                    {

                        this.Hide();
                        Session.MenuChoiceForm.Show();
                        return;
                    }
                    if (user.MemberType == "Admin")
                    {
                        this.Hide();
                        Session.AdminForm.Show();
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eksik ya da yanlış bilgi girmiş olabilirsiniz.");
            }
        }

        private void btnGirisYap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (var db = new ProjectContext())
                    {
                        var user = db.Users.FirstOrDefault(x => x.UserName == txtKullaniciAdiGiris.Text && x.Password == txtParolaGiris.Text);

                        if (user == null)
                        {
                            MessageBox.Show("Kullanıcı adı ile şifre uyuşmamaktadır.");
                            return;
                        }
                        Session.CurrentUser = user;
                        if (user.MemberType != "Admin")
                        {

                            this.Hide();
                            Session.MenuChoiceForm.Show();
                            return;
                        }
                        if (user.MemberType == "Admin")
                        {
                            this.Hide();
                            Session.AdminForm.Show();
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eksik ya da yanlış bilgi girmiş olabilirsiniz.");
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            GetMotivatedWords();
        }

        private void GetMotivatedWords()
        {
            lblMotivationwords.Visible = true;
            var rnd = new Random();
            using (var db = new ProjectContext())
            {
                var allWords = db.MotivationWords.ToList();
                foreach (var word in allWords)
                {
                    allMotivationWords.Add(word.Word);
                }
            }
            wordNumber = rnd.Next(0, allMotivationWords.Count());
            lblMotivationwords.Text = allMotivationWords[wordNumber];
        }
    }
}