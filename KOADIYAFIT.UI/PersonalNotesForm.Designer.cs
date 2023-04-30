namespace KOADIYAFIT.UI
{
    partial class PersonalNotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalNotesForm));
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.dtSelectedDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnListNotes = new System.Windows.Forms.Button();
            this.txtPersonalNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNotes
            // 
            this.lstNotes.BackColor = System.Drawing.SystemColors.Info;
            this.lstNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstNotes.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstNotes.ForeColor = System.Drawing.Color.Black;
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.ItemHeight = 29;
            this.lstNotes.Location = new System.Drawing.Point(12, 226);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(858, 116);
            this.lstNotes.TabIndex = 0;
            // 
            // dtSelectedDate
            // 
            this.dtSelectedDate.Location = new System.Drawing.Point(342, 41);
            this.dtSelectedDate.Name = "dtSelectedDate";
            this.dtSelectedDate.Size = new System.Drawing.Size(200, 23);
            this.dtSelectedDate.TabIndex = 1;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNote.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNote.ForeColor = System.Drawing.Color.White;
            this.btnSaveNote.Location = new System.Drawing.Point(391, 177);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(110, 43);
            this.btnSaveNote.TabIndex = 2;
            this.btnSaveNote.Text = "KAYDET";
            this.btnSaveNote.UseVisualStyleBackColor = false;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnListNotes
            // 
            this.btnListNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnListNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListNotes.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListNotes.ForeColor = System.Drawing.Color.White;
            this.btnListNotes.Location = new System.Drawing.Point(391, 356);
            this.btnListNotes.Name = "btnListNotes";
            this.btnListNotes.Size = new System.Drawing.Size(110, 43);
            this.btnListNotes.TabIndex = 3;
            this.btnListNotes.Text = "LİSTELE";
            this.btnListNotes.UseVisualStyleBackColor = false;
            this.btnListNotes.Click += new System.EventHandler(this.btnListNotes_Click);
            // 
            // txtPersonalNote
            // 
            this.txtPersonalNote.BackColor = System.Drawing.SystemColors.Info;
            this.txtPersonalNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonalNote.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPersonalNote.Location = new System.Drawing.Point(12, 100);
            this.txtPersonalNote.Multiline = true;
            this.txtPersonalNote.Name = "txtPersonalNote";
            this.txtPersonalNote.Size = new System.Drawing.Size(858, 61);
            this.txtPersonalNote.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gün Sonu Raporum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonalNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPersonalNote);
            this.Controls.Add(this.btnListNotes);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.dtSelectedDate);
            this.Controls.Add(this.lstNotes);
            this.Name = "PersonalNotesForm";
            this.Text = "PersonalNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstNotes;
        private DateTimePicker dtSelectedDate;
        private Button btnSaveNote;
        private Button btnListNotes;
        private TextBox txtPersonalNote;
        private Button button1;
    }
}