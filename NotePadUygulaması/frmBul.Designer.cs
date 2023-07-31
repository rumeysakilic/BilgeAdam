namespace NotePadUygulaması
{
    partial class frmBul
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
            button1 = new Button();
            button2 = new Button();
            cbTumKelimeyiSec = new CheckBox();
            txtAranan = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(302, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Bul";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(302, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbTumKelimeyiSec
            // 
            cbTumKelimeyiSec.AutoSize = true;
            cbTumKelimeyiSec.Checked = true;
            cbTumKelimeyiSec.CheckState = CheckState.Checked;
            cbTumKelimeyiSec.Location = new Point(12, 54);
            cbTumKelimeyiSec.Name = "cbTumKelimeyiSec";
            cbTumKelimeyiSec.Size = new Size(204, 19);
            cbTumKelimeyiSec.TabIndex = 2;
            cbTumKelimeyiSec.Text = "Bulduktan sonra tüm kelimeyi seç";
            cbTumKelimeyiSec.UseVisualStyleBackColor = true;
            // 
            // txtAranan
            // 
            txtAranan.Location = new Point(66, 13);
            txtAranan.Name = "txtAranan";
            txtAranan.Size = new Size(230, 23);
            txtAranan.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Aranan:";
            // 
            // frmBul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 110);
            Controls.Add(label1);
            Controls.Add(txtAranan);
            Controls.Add(cbTumKelimeyiSec);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmBul";
            Text = "Kelime Bul";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        public CheckBox cbTumKelimeyiSec;
        public TextBox txtAranan;
        private Label label1;
    }
}