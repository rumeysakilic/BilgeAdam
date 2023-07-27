namespace StructOgrenci
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
            btnOgrenciEkle = new Button();
            textBox1 = new TextBox();
            btnOzellikleriGoruntule = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            btnOrtalamaHesapla = new Button();
            SuspendLayout();
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(111, 12);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(162, 28);
            btnOgrenciEkle.TabIndex = 0;
            btnOgrenciEkle.Text = "Kayıt Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(111, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 91);
            textBox1.TabIndex = 1;
            // 
            // btnOzellikleriGoruntule
            // 
            btnOzellikleriGoruntule.Location = new Point(111, 180);
            btnOzellikleriGoruntule.Name = "btnOzellikleriGoruntule";
            btnOzellikleriGoruntule.Size = new Size(162, 28);
            btnOzellikleriGoruntule.TabIndex = 2;
            btnOzellikleriGoruntule.Text = "Özellikleri Görüntüle";
            btnOzellikleriGoruntule.UseVisualStyleBackColor = true;
            btnOzellikleriGoruntule.Click += btnOzellikleriGoruntule_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 222);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 4;
            label1.Text = "Hangi indisdeki öğrenci:";
            // 
            // btnOrtalamaHesapla
            // 
            btnOrtalamaHesapla.Location = new Point(111, 295);
            btnOrtalamaHesapla.Name = "btnOrtalamaHesapla";
            btnOrtalamaHesapla.Size = new Size(162, 28);
            btnOrtalamaHesapla.TabIndex = 5;
            btnOrtalamaHesapla.Text = "Ortalama Hesapla";
            btnOrtalamaHesapla.UseVisualStyleBackColor = true;
            btnOrtalamaHesapla.Click += btnOrtalamaHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(415, 450);
            Controls.Add(btnOrtalamaHesapla);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnOzellikleriGoruntule);
            Controls.Add(textBox1);
            Controls.Add(btnOgrenciEkle);
            Name = "Form1";
            Text = "Öğrenci Kayıt Formu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOgrenciEkle;
        private TextBox textBox1;
        private Button btnOzellikleriGoruntule;
        private TextBox textBox2;
        private Label label1;
        private Button btnOrtalamaHesapla;
    }
}