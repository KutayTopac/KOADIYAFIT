namespace KOADIYAFIT.UI
{
    partial class RaporForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dtCreatedTime = new System.Windows.Forms.DateTimePicker();
            this.cmbMealTypeView = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.btnOgunSecimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonalNotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Görüntülemek İstediğiniz Raporun Tarihini Seçiniz";
            // 
            // dtCreatedTime
            // 
            this.dtCreatedTime.CustomFormat = "dd MMMM yyyy";
            this.dtCreatedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatedTime.Location = new System.Drawing.Point(451, 72);
            this.dtCreatedTime.Name = "dtCreatedTime";
            this.dtCreatedTime.Size = new System.Drawing.Size(200, 23);
            this.dtCreatedTime.TabIndex = 2;
            // 
            // cmbMealTypeView
            // 
            this.cmbMealTypeView.DisplayMember = "MealTypeName";
            this.cmbMealTypeView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealTypeView.FormattingEnabled = true;
            this.cmbMealTypeView.Location = new System.Drawing.Point(486, 152);
            this.cmbMealTypeView.Name = "cmbMealTypeView";
            this.cmbMealTypeView.Size = new System.Drawing.Size(121, 23);
            this.cmbMealTypeView.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Transparent;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(486, 215);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 38);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvRapor
            // 
            this.dgvRapor.AllowUserToAddRows = false;
            this.dgvRapor.AllowUserToDeleteRows = false;
            this.dgvRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRapor.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvRapor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRapor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRapor.GridColor = System.Drawing.Color.SeaShell;
            this.dgvRapor.Location = new System.Drawing.Point(204, 270);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.ReadOnly = true;
            this.dgvRapor.RowTemplate.Height = 25;
            this.dgvRapor.Size = new System.Drawing.Size(698, 295);
            this.dgvRapor.TabIndex = 5;
            // 
            // btnOgunSecimi
            // 
            this.btnOgunSecimi.BackColor = System.Drawing.Color.Transparent;
            this.btnOgunSecimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgunSecimi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOgunSecimi.ForeColor = System.Drawing.Color.White;
            this.btnOgunSecimi.Location = new System.Drawing.Point(970, 615);
            this.btnOgunSecimi.Name = "btnOgunSecimi";
            this.btnOgunSecimi.Size = new System.Drawing.Size(150, 66);
            this.btnOgunSecimi.TabIndex = 6;
            this.btnOgunSecimi.Text = "ÖĞÜN SEÇİMİ";
            this.btnOgunSecimi.UseVisualStyleBackColor = false;
            this.btnOgunSecimi.Click += new System.EventHandler(this.btnOgunSecimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lütfen Görüntülemek İstediğiniz Öğünü Seçiniz";
            // 
            // btnPersonalNotes
            // 
            this.btnPersonalNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonalNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPersonalNotes.ForeColor = System.Drawing.Color.White;
            this.btnPersonalNotes.Location = new System.Drawing.Point(12, 615);
            this.btnPersonalNotes.Name = "btnPersonalNotes";
            this.btnPersonalNotes.Size = new System.Drawing.Size(150, 66);
            this.btnPersonalNotes.TabIndex = 8;
            this.btnPersonalNotes.Text = "KİŞİSEL NOTLARIM";
            this.btnPersonalNotes.UseVisualStyleBackColor = false;
            this.btnPersonalNotes.Click += new System.EventHandler(this.btnPersonalNotes_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 693);
            this.Controls.Add(this.btnPersonalNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOgunSecimi);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbMealTypeView);
            this.Controls.Add(this.dtCreatedTime);
            this.Controls.Add(this.label1);
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaporForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DateTimePicker dtCreatedTime;
        private ComboBox cmbMealTypeView;
        private Button btnListele;
        private DataGridView dgvRapor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnOgunSecimi;
        private Label label2;
        private Button btnPersonalNotes;
    }
}