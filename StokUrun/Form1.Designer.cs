namespace StokUrun
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
            txtKategoriAdı = new TextBox();
            btnEkle = new Button();
            ToplamUrun = new TextBox();
            chlistKategoriler = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı:";
            // 
            // txtKategoriAdı
            // 
            txtKategoriAdı.Location = new Point(93, 22);
            txtKategoriAdı.Name = "txtKategoriAdı";
            txtKategoriAdı.Size = new Size(109, 23);
            txtKategoriAdı.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(127, 65);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // ToplamUrun
            // 
            ToplamUrun.Location = new Point(208, 116);
            ToplamUrun.Multiline = true;
            ToplamUrun.Name = "ToplamUrun";
            ToplamUrun.Size = new Size(139, 112);
            ToplamUrun.TabIndex = 9;
            // 
            // chlistKategoriler
            // 
            chlistKategoriler.FormattingEnabled = true;
            chlistKategoriler.Items.AddRange(new object[] { "Film ", "Müzik", "Bilgisayar", "Kitap" });
            chlistKategoriler.Location = new Point(12, 116);
            chlistKategoriler.Name = "chlistKategoriler";
            chlistKategoriler.Size = new Size(190, 112);
            chlistKategoriler.TabIndex = 10;
            chlistKategoriler.SelectedIndexChanged += chlistKategoriler_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 262);
            Controls.Add(chlistKategoriler);
            Controls.Add(ToplamUrun);
            Controls.Add(btnEkle);
            Controls.Add(txtKategoriAdı);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Stok Urun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKategoriAdı;
        private Button btnEkle;
        private TextBox ToplamUrun;
        private CheckedListBox chlistKategoriler;
    }
}