namespace UrunTedarik
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
            lbTedarikci = new ListBox();
            button1 = new Button();
            lblUrunFiyat = new TextBox();
            lbStok = new ListBox();
            label2 = new Label();
            btnCikar = new Button();
            btnHesapla = new Button();
            label3 = new Label();
            label4 = new Label();
            txtToplam = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Tedarikçideki Ürünler:";
            // 
            // lbTedarikci
            // 
            lbTedarikci.FormattingEnabled = true;
            lbTedarikci.ItemHeight = 15;
            lbTedarikci.Location = new Point(12, 56);
            lbTedarikci.Name = "lbTedarikci";
            lbTedarikci.Size = new Size(120, 109);
            lbTedarikci.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(156, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "EKLE>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblUrunFiyat
            // 
            lblUrunFiyat.Location = new Point(295, 214);
            lblUrunFiyat.Name = "lblUrunFiyat";
            lblUrunFiyat.Size = new Size(78, 23);
            lblUrunFiyat.TabIndex = 3;
            // 
            // lbStok
            // 
            lbStok.FormattingEnabled = true;
            lbStok.ItemHeight = 15;
            lbStok.Location = new Point(253, 56);
            lbStok.Name = "lbStok";
            lbStok.Size = new Size(120, 109);
            lbStok.TabIndex = 4;
            lbStok.SelectedIndexChanged += lbStok_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 22);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Stoktaki Ürünler:";
            label2.Click += label2_Click;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(156, 101);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(75, 23);
            btnCikar.TabIndex = 6;
            btnCikar.Text = "<<ÇIKAR";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(156, 144);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(75, 23);
            btnHesapla.TabIndex = 7;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 217);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Seçilen Ürünler:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 260);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Toplam:";
            // 
            // txtToplam
            // 
            txtToplam.Location = new Point(253, 260);
            txtToplam.Name = "txtToplam";
            txtToplam.Size = new Size(120, 23);
            txtToplam.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 316);
            Controls.Add(txtToplam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnHesapla);
            Controls.Add(btnCikar);
            Controls.Add(label2);
            Controls.Add(lbStok);
            Controls.Add(lblUrunFiyat);
            Controls.Add(button1);
            Controls.Add(lbTedarikci);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ÜRÜN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbTedarikci;
        private Button button1;
        private TextBox lblUrunFiyat;
        private ListBox lbStok;
        private Label label2;
        private Button btnCikar;
        private Button btnHesapla;
        private Label label3;
        private Label label4;
        private TextBox txtToplam;
    }
}