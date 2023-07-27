namespace ŞifrelemeAlgoritması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSifre = new Label();
            btnSifrele = new Button();
            lblDesifre = new Label();
            btnSifreyiCoz = new Button();
            txtSifrelenecekYazi = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(21, 24);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(30, 15);
            lblSifre.TabIndex = 0;
            lblSifre.Text = "Şifre";
            // 
            // btnSifrele
            // 
            btnSifrele.Location = new Point(21, 60);
            btnSifrele.Name = "btnSifrele";
            btnSifrele.Size = new Size(75, 23);
            btnSifrele.TabIndex = 1;
            btnSifrele.Text = "Şifrele";
            btnSifrele.UseVisualStyleBackColor = true;
            btnSifrele.Click += btnSifrele_Click;
            // 
            // lblDesifre
            // 
            lblDesifre.AutoSize = true;
            lblDesifre.Location = new Point(184, 24);
            lblDesifre.Name = "lblDesifre";
            lblDesifre.Size = new Size(43, 15);
            lblDesifre.TabIndex = 2;
            lblDesifre.Text = "Deşifre";
            // 
            // btnSifreyiCoz
            // 
            btnSifreyiCoz.Location = new Point(184, 60);
            btnSifreyiCoz.Name = "btnSifreyiCoz";
            btnSifreyiCoz.Size = new Size(75, 23);
            btnSifreyiCoz.TabIndex = 3;
            btnSifreyiCoz.Text = "Şifreyi Çöz";
            btnSifreyiCoz.UseVisualStyleBackColor = true;
            // 
            // txtSifrelenecekYazi
            // 
            txtSifrelenecekYazi.Location = new Point(159, 117);
            txtSifrelenecekYazi.Name = "txtSifrelenecekYazi";
            txtSifrelenecekYazi.Size = new Size(100, 23);
            txtSifrelenecekYazi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 120);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Şifre gir:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 360);
            Controls.Add(label1);
            Controls.Add(txtSifrelenecekYazi);
            Controls.Add(btnSifreyiCoz);
            Controls.Add(lblDesifre);
            Controls.Add(btnSifrele);
            Controls.Add(lblSifre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSifre;
        private Button btnSifrele;
        private Label lblDesifre;
        private Button btnSifreyiCoz;
        private TextBox txtSifrelenecekYazi;
        private Label label1;
    }
}