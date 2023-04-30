namespace KOADIYAFIT
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdiGiris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParolaGiris = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblMotivationwords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(343, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdiGiris
            // 
            this.txtKullaniciAdiGiris.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtKullaniciAdiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdiGiris.Location = new System.Drawing.Point(511, 183);
            this.txtKullaniciAdiGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKullaniciAdiGiris.Multiline = true;
            this.txtKullaniciAdiGiris.Name = "txtKullaniciAdiGiris";
            this.txtKullaniciAdiGiris.Size = new System.Drawing.Size(194, 32);
            this.txtKullaniciAdiGiris.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(412, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola :";
            // 
            // txtParolaGiris
            // 
            this.txtParolaGiris.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtParolaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtParolaGiris.Location = new System.Drawing.Point(511, 260);
            this.txtParolaGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtParolaGiris.Multiline = true;
            this.txtParolaGiris.Name = "txtParolaGiris";
            this.txtParolaGiris.PasswordChar = '*';
            this.txtParolaGiris.Size = new System.Drawing.Size(194, 32);
            this.txtParolaGiris.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGirisYap.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.Location = new System.Drawing.Point(554, 321);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(152, 54);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGirisYap_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.linkLabel1.Location = new System.Drawing.Point(444, 405);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(261, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Değil misiniz? Lütfen kayıt olun!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblMotivationwords
            // 
            this.lblMotivationwords.AutoSize = true;
            this.lblMotivationwords.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivationwords.Font = new System.Drawing.Font("Gabriola", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMotivationwords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMotivationwords.Location = new System.Drawing.Point(12, 578);
            this.lblMotivationwords.Name = "lblMotivationwords";
            this.lblMotivationwords.Size = new System.Drawing.Size(84, 55);
            this.lblMotivationwords.TabIndex = 6;
            this.lblMotivationwords.Text = "label3";
            this.lblMotivationwords.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 642);
            this.Controls.Add(this.lblMotivationwords);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtParolaGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdiGiris);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1152, 681);
            this.MinimumSize = new System.Drawing.Size(1152, 681);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdiGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParolaGiris;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Label lblMotivationwords;
    }
}

