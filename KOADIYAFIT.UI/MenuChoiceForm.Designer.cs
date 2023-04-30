namespace KOADIYAFIT.UI
{
    partial class MenuChoiceForm
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
            this.flpMealType = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpMealType
            // 
            this.flpMealType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMealType.Location = new System.Drawing.Point(0, 0);
            this.flpMealType.Name = "flpMealType";
            this.flpMealType.Size = new System.Drawing.Size(864, 506);
            this.flpMealType.TabIndex = 0;
            // 
            // MenuChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 506);
            this.Controls.Add(this.flpMealType);
            this.Name = "MenuChoiceForm";
            this.Text = "TestMenuChoiceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuChoiceForm_FormClosed);
            this.Shown += new System.EventHandler(this.TestMenuChoiceForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpMealType;
    }
}