namespace Yazılım___Sistem_Zümreleri_Eğitim_Anketleri
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
            groupBox1 = new GroupBox();
            grpSistem = new RadioButton();
            grpYazilim = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            label1 = new Label();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton9 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton14 = new RadioButton();
            groupBox4 = new GroupBox();
            btnOnayla = new Button();
            pnlAnket = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            pnlAnket.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grpSistem);
            groupBox1.Controls.Add(grpYazilim);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(127, 126);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınıflar:";
            // 
            // grpSistem
            // 
            grpSistem.AutoSize = true;
            grpSistem.Location = new Point(6, 46);
            grpSistem.Name = "grpSistem";
            grpSistem.Size = new Size(60, 19);
            grpSistem.TabIndex = 1;
            grpSistem.TabStop = true;
            grpSistem.Text = "Sistem";
            grpSistem.UseVisualStyleBackColor = true;
            // 
            // grpYazilim
            // 
            grpYazilim.AutoSize = true;
            grpYazilim.Location = new Point(6, 21);
            grpYazilim.Name = "grpYazilim";
            grpYazilim.Size = new Size(62, 19);
            grpYazilim.TabIndex = 0;
            grpYazilim.TabStop = true;
            grpYazilim.Text = "Yazılım";
            grpYazilim.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(9, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(98, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "MCSD Eğitimi";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(9, 62);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(118, 19);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Yazılım Uzmanlığı";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(240, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 126);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürünler(Yazılım):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 161);
            label1.Name = "label1";
            label1.Size = new Size(267, 25);
            label1.TabIndex = 5;
            label1.Text = "MCSD Eğitimi İçin Anket Girişi:";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.CheckAlign = ContentAlignment.TopCenter;
            radioButton7.Location = new Point(256, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(60, 32);
            radioButton7.TabIndex = 8;
            radioButton7.TabStop = true;
            radioButton7.Text = "Çok Kötü";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.CheckAlign = ContentAlignment.TopCenter;
            radioButton8.Location = new Point(194, 22);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(36, 32);
            radioButton8.TabIndex = 9;
            radioButton8.TabStop = true;
            radioButton8.Text = "Kötü";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.CheckAlign = ContentAlignment.TopCenter;
            radioButton5.Location = new Point(0, 22);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(47, 32);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "Çok İyi";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.CheckAlign = ContentAlignment.TopCenter;
            radioButton6.Location = new Point(74, 22);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(23, 32);
            radioButton6.TabIndex = 11;
            radioButton6.TabStop = true;
            radioButton6.Text = "İyi";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.CheckAlign = ContentAlignment.TopCenter;
            radioButton9.Location = new Point(121, 22);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(43, 32);
            radioButton9.TabIndex = 12;
            radioButton9.TabStop = true;
            radioButton9.Text = "Yeterli";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Location = new Point(3, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(345, 77);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eğitim İçeriği:";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.CheckAlign = ContentAlignment.TopCenter;
            radioButton10.Location = new Point(6, 31);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(47, 32);
            radioButton10.TabIndex = 14;
            radioButton10.TabStop = true;
            radioButton10.Text = "Çok İyi";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.CheckAlign = ContentAlignment.TopCenter;
            radioButton11.Location = new Point(70, 31);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(23, 32);
            radioButton11.TabIndex = 15;
            radioButton11.TabStop = true;
            radioButton11.Text = "İyi";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.CheckAlign = ContentAlignment.TopCenter;
            radioButton12.Location = new Point(117, 31);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(43, 32);
            radioButton12.TabIndex = 16;
            radioButton12.TabStop = true;
            radioButton12.Text = "Yeterli";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.CheckAlign = ContentAlignment.TopCenter;
            radioButton13.Location = new Point(190, 31);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(36, 32);
            radioButton13.TabIndex = 17;
            radioButton13.TabStop = true;
            radioButton13.Text = "Kötü";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.CheckAlign = ContentAlignment.TopCenter;
            radioButton14.Location = new Point(252, 31);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(60, 32);
            radioButton14.TabIndex = 18;
            radioButton14.TabStop = true;
            radioButton14.Text = "Çok Kötü";
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton10);
            groupBox4.Controls.Add(radioButton14);
            groupBox4.Controls.Add(radioButton11);
            groupBox4.Controls.Add(radioButton13);
            groupBox4.Controls.Add(radioButton12);
            groupBox4.Location = new Point(3, 83);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(343, 69);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eğitim Araç Gereçleri:";
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(336, 347);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(75, 23);
            btnOnayla.TabIndex = 20;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            // 
            // pnlAnket
            // 
            pnlAnket.Controls.Add(groupBox3);
            pnlAnket.Controls.Add(groupBox4);
            pnlAnket.Location = new Point(31, 189);
            pnlAnket.Name = "pnlAnket";
            pnlAnket.Size = new Size(364, 152);
            pnlAnket.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 396);
            Controls.Add(btnOnayla);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlAnket);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            pnlAnket.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox2;
        private Label label1;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton9;
        private GroupBox groupBox3;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private GroupBox groupBox4;
        private Button btnOnayla;
        private RadioButton grpSistem;
        private RadioButton grpYazilim;
        private Panel pnlAnket;
    }
}