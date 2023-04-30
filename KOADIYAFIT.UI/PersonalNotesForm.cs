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
    public partial class PersonalNotesForm : Form
    {
        public PersonalNotesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session.RaporForm.Show();
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (txtPersonalNote.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kaydetmek için bir not yazınız.");
                return;
            }

            using (var db = new ProjectContext())
            {
                var personelNote = new PersonelNote()
                {
                    Note = txtPersonalNote.Text,
                    CreatedDate = DateTime.Now.Date,
                    UserId = Session.CurrentUser.Id
                };
                db.PersonelNotes.Add(personelNote);
                db.SaveChanges();
            }
            MessageBox.Show("Not oluşturma işleminiz başarıyla kaydedilmiştir.");
            txtPersonalNote.Text = "";
        }

        private void btnListNotes_Click(object sender, EventArgs e)
        {
            var selectedDate = dtSelectedDate.Value.Date;
            var currentUserId = Session.CurrentUser.Id;

            using (var db = new ProjectContext())
            {
                lstNotes.Items.Clear();
                var personalNotes = db.PersonelNotes.Where(x => x.UserId == currentUserId && x.CreatedDate.Date == selectedDate).ToList();
                foreach (var note in personalNotes)
                {
                    lstNotes.Items.Add(note.Note);
                }
            }
        }
    }
}
