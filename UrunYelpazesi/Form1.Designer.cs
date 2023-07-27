namespace UrunYelpazesi
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
            lbUrunler = new ListBox();
            lbKategoriler = new ListBox();
            cmbTarihSirasi = new ComboBox();
            cmbStokDurumu = new ComboBox();
            lblMesaj = new Label();
            lblSecilenUrunler = new Label();
            btnListele = new Button();
            SuspendLayout();
            // 
            // lbUrunler
            // 
            lbUrunler.FormattingEnabled = true;
            lbUrunler.ItemHeight = 15;
            lbUrunler.Location = new Point(25, 75);
            lbUrunler.Name = "lbUrunler";
            lbUrunler.Size = new Size(120, 94);
            lbUrunler.TabIndex = 0;
            // 
            // lbKategoriler
            // 
            lbKategoriler.FormattingEnabled = true;
            lbKategoriler.ItemHeight = 15;
            lbKategoriler.Items.AddRange(new object[] { "• Video ", "• Kitap ", "• Yazılım" });
            lbKategoriler.Location = new Point(186, 75);
            lbKategoriler.Name = "lbKategoriler";
            lbKategoriler.Size = new Size(120, 94);
            lbKategoriler.TabIndex = 1;
            // 
            // cmbTarihSirasi
            // 
            cmbTarihSirasi.FormattingEnabled = true;
            cmbTarihSirasi.Items.AddRange(new object[] { "Son Çıkanlar", "Tüm Üürünler" });
            cmbTarihSirasi.Location = new Point(24, 203);
            cmbTarihSirasi.Name = "cmbTarihSirasi";
            cmbTarihSirasi.Size = new Size(121, 23);
            cmbTarihSirasi.TabIndex = 2;
            // 
            // cmbStokDurumu
            // 
            cmbStokDurumu.FormattingEnabled = true;
            cmbStokDurumu.Items.AddRange(new object[] { "Sadece Stoktakiler", "Hepsi" });
            cmbStokDurumu.Location = new Point(186, 203);
            cmbStokDurumu.Name = "cmbStokDurumu";
            cmbStokDurumu.Size = new Size(121, 23);
            cmbStokDurumu.TabIndex = 3;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Dock = DockStyle.Bottom;
            lblMesaj.Location = new Point(0, 356);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(38, 15);
            lblMesaj.TabIndex = 4;
            lblMesaj.Text = "label1";
            // 
            // lblSecilenUrunler
            // 
            lblSecilenUrunler.AutoSize = true;
            lblSecilenUrunler.Location = new Point(25, 42);
            lblSecilenUrunler.Name = "lblSecilenUrunler";
            lblSecilenUrunler.Size = new Size(96, 15);
            lblSecilenUrunler.TabIndex = 5;
            lblSecilenUrunler.Text = "lblSecilenUrunler";
            // 
            // btnListele
            // 
            btnListele.Location = new Point(186, 261);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(121, 23);
            btnListele.TabIndex = 6;
            btnListele.Text = "Listele!";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(360, 371);
            Controls.Add(btnListele);
            Controls.Add(lblSecilenUrunler);
            Controls.Add(lblMesaj);
            Controls.Add(cmbStokDurumu);
            Controls.Add(cmbTarihSirasi);
            Controls.Add(lbKategoriler);
            Controls.Add(lbUrunler);
            Name = "Form1";
            Text = "Ürün Yelpazesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbUrunler;
        private ListBox lbKategoriler;
        private ComboBox cmbTarihSirasi;
        private ComboBox cmbStokDurumu;
        private Label lblMesaj;
        private Label lblSecilenUrunler;
        private Button btnListele;
    }
}