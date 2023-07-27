namespace AbonelikIslemleri
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAcilisTutari = new TextBox();
            cbKDV = new CheckBox();
            cbOzelIletisimIlkFatura = new CheckBox();
            OzelIletisim = new CheckBox();
            txtToplam = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "AçılışTutarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 31);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 180);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Toplam:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 180);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "TL";
            // 
            // txtAcilisTutari
            // 
            txtAcilisTutari.Location = new Point(106, 28);
            txtAcilisTutari.Name = "txtAcilisTutari";
            txtAcilisTutari.Size = new Size(188, 23);
            txtAcilisTutari.TabIndex = 4;
            // 
            // cbKDV
            // 
            cbKDV.AutoSize = true;
            cbKDV.Location = new Point(106, 77);
            cbKDV.Name = "cbKDV";
            cbKDV.Size = new Size(76, 19);
            cbKDV.TabIndex = 5;
            cbKDV.Text = "KDV: %18";
            cbKDV.UseVisualStyleBackColor = true;
            // 
            // cbOzelIletisimIlkFatura
            // 
            cbOzelIletisimIlkFatura.AutoSize = true;
            cbOzelIletisimIlkFatura.Location = new Point(106, 102);
            cbOzelIletisimIlkFatura.Name = "cbOzelIletisimIlkFatura";
            cbOzelIletisimIlkFatura.Size = new Size(226, 19);
            cbOzelIletisimIlkFatura.TabIndex = 6;
            cbOzelIletisimIlkFatura.Text = "Özel İletişim Vergisi(İlk Faturada): 22TL";
            cbOzelIletisimIlkFatura.UseVisualStyleBackColor = true;
            cbOzelIletisimIlkFatura.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // OzelIletisim
            // 
            OzelIletisim.AutoSize = true;
            OzelIletisim.Location = new Point(106, 127);
            OzelIletisim.Name = "OzelIletisim";
            OzelIletisim.Size = new Size(155, 19);
            OzelIletisim.TabIndex = 7;
            OzelIletisim.Text = "Özel İletişim Vergisi: %25";
            OzelIletisim.UseVisualStyleBackColor = true;
            // 
            // txtToplam
            // 
            txtToplam.Location = new Point(106, 172);
            txtToplam.Name = "txtToplam";
            txtToplam.Size = new Size(188, 23);
            txtToplam.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(300, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 251);
            Controls.Add(button1);
            Controls.Add(txtToplam);
            Controls.Add(OzelIletisim);
            Controls.Add(cbOzelIletisimIlkFatura);
            Controls.Add(cbKDV);
            Controls.Add(txtAcilisTutari);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Abonelik İşlemleri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAcilisTutari;
        private CheckBox cbKDV;
        private CheckBox cbOzelIletisimIlkFatura;
        private CheckBox OzelIletisim;
        private TextBox txtToplam;
        private Button button1;
    }
}