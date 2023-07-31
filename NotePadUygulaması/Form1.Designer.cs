namespace NotePadUygulaması
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            StatusBar1 = new StatusStrip();
            lblKaydedildi = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            geriAlToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            bulToolStripMenuItem = new ToolStripMenuItem();
            yazıTipiToolStripMenuItem = new ToolStripMenuItem();
            tümünüSeçToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            solaHizalaToolStripMenuItem = new ToolStripMenuItem();
            sağaHizalaToolStripMenuItem = new ToolStripMenuItem();
            ortalaToolStripMenuItem = new ToolStripMenuItem();
            maddeİşaretleToolStripMenuItem = new ToolStripMenuItem();
            araçÇubuğunuGizleToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem1 = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            toolStripButton10 = new ToolStripButton();
            toolStripButton11 = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            geriAlToolStripMenuItem1 = new ToolStripMenuItem();
            kesToolStripMenuItem1 = new ToolStripMenuItem();
            kopyalaToolStripMenuItem1 = new ToolStripMenuItem();
            yapıştırToolStripMenuItem1 = new ToolStripMenuItem();
            silToolStripMenuItem1 = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            StatusBar1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(581, 227);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // StatusBar1
            // 
            StatusBar1.Items.AddRange(new ToolStripItem[] { lblKaydedildi });
            StatusBar1.Location = new Point(0, 299);
            StatusBar1.Name = "StatusBar1";
            StatusBar1.RenderMode = ToolStripRenderMode.Professional;
            StatusBar1.Size = new Size(586, 22);
            StatusBar1.TabIndex = 2;
            StatusBar1.Text = "statusStrip1";
            // 
            // lblKaydedildi
            // 
            lblKaydedildi.Name = "lblKaydedildi";
            lblKaydedildi.Size = new Size(79, 17);
            lblKaydedildi.Text = "Kaydedilmedi";
            lblKaydedildi.Click += toolStripStatusLabel1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem, yardımToolStripMenuItem, yardımToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(586, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, açToolStripMenuItem, kaydetToolStripMenuItem, farklıKaydetToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            yeniToolStripMenuItem.Size = new Size(150, 22);
            yeniToolStripMenuItem.Text = "Yeni";
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            açToolStripMenuItem.Size = new Size(150, 22);
            açToolStripMenuItem.Text = "Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            kaydetToolStripMenuItem.Size = new Size(150, 22);
            kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            farklıKaydetToolStripMenuItem.Size = new Size(150, 22);
            farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(150, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geriAlToolStripMenuItem, kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem, silToolStripMenuItem, bulToolStripMenuItem, yazıTipiToolStripMenuItem, tümünüSeçToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // geriAlToolStripMenuItem
            // 
            geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            geriAlToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            geriAlToolStripMenuItem.Size = new Size(158, 22);
            geriAlToolStripMenuItem.Text = "Geri Al";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            kesToolStripMenuItem.Size = new Size(158, 22);
            kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopyalaToolStripMenuItem.Size = new Size(158, 22);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            yapıştırToolStripMenuItem.Size = new Size(158, 22);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(158, 22);
            silToolStripMenuItem.Text = "Sil";
            // 
            // bulToolStripMenuItem
            // 
            bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            bulToolStripMenuItem.Size = new Size(158, 22);
            bulToolStripMenuItem.Text = "Bul";
            // 
            // yazıTipiToolStripMenuItem
            // 
            yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            yazıTipiToolStripMenuItem.Size = new Size(158, 22);
            yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            // 
            // tümünüSeçToolStripMenuItem
            // 
            tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            tümünüSeçToolStripMenuItem.Size = new Size(158, 22);
            tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { solaHizalaToolStripMenuItem, sağaHizalaToolStripMenuItem, ortalaToolStripMenuItem, maddeİşaretleToolStripMenuItem, araçÇubuğunuGizleToolStripMenuItem });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(70, 20);
            yardımToolStripMenuItem.Text = "Görünüm";
            // 
            // solaHizalaToolStripMenuItem
            // 
            solaHizalaToolStripMenuItem.Name = "solaHizalaToolStripMenuItem";
            solaHizalaToolStripMenuItem.Size = new Size(186, 22);
            solaHizalaToolStripMenuItem.Text = "Sola Hizala";
            // 
            // sağaHizalaToolStripMenuItem
            // 
            sağaHizalaToolStripMenuItem.Name = "sağaHizalaToolStripMenuItem";
            sağaHizalaToolStripMenuItem.Size = new Size(186, 22);
            sağaHizalaToolStripMenuItem.Text = "Sağa Hizala";
            // 
            // ortalaToolStripMenuItem
            // 
            ortalaToolStripMenuItem.Name = "ortalaToolStripMenuItem";
            ortalaToolStripMenuItem.Size = new Size(186, 22);
            ortalaToolStripMenuItem.Text = "Ortala";
            // 
            // maddeİşaretleToolStripMenuItem
            // 
            maddeİşaretleToolStripMenuItem.Name = "maddeİşaretleToolStripMenuItem";
            maddeİşaretleToolStripMenuItem.Size = new Size(186, 22);
            maddeİşaretleToolStripMenuItem.Text = "Madde İşaretle";
            // 
            // araçÇubuğunuGizleToolStripMenuItem
            // 
            araçÇubuğunuGizleToolStripMenuItem.Name = "araçÇubuğunuGizleToolStripMenuItem";
            araçÇubuğunuGizleToolStripMenuItem.Size = new Size(186, 22);
            araçÇubuğunuGizleToolStripMenuItem.Text = "Araç Çubuğunu Gizle";
            // 
            // yardımToolStripMenuItem1
            // 
            yardımToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { hakkındaToolStripMenuItem });
            yardımToolStripMenuItem1.Name = "yardımToolStripMenuItem1";
            yardımToolStripMenuItem1.Size = new Size(56, 20);
            yardımToolStripMenuItem1.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(124, 22);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6, toolStripButton7, toolStripButton8, toolStripButton9, toolStripButton10, toolStripButton11 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(586, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.AccessibleName = "Kaydet";
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.kaydet;
            toolStripButton1.ImageAlign = ContentAlignment.BottomCenter;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.dosyaç;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.kopyala;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.kes;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.dosyaç;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = Properties.Resources.geri;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 22);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = Properties.Resources.ileri;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(23, 22);
            toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(23, 22);
            toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton9.Image = Properties.Resources.solayasla;
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(23, 22);
            toolStripButton9.Text = "toolStripButton9";
            // 
            // toolStripButton10
            // 
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton10.Image = Properties.Resources.ortala;
            toolStripButton10.ImageTransparentColor = Color.Magenta;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(23, 22);
            toolStripButton10.Text = "toolStripButton10";
            // 
            // toolStripButton11
            // 
            toolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton11.Image = Properties.Resources.sağayasla;
            toolStripButton11.ImageTransparentColor = Color.Magenta;
            toolStripButton11.Name = "toolStripButton11";
            toolStripButton11.Size = new Size(23, 22);
            toolStripButton11.Text = "toolStripButton11";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { geriAlToolStripMenuItem1, kesToolStripMenuItem1, kopyalaToolStripMenuItem1, yapıştırToolStripMenuItem1, silToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 114);
            // 
            // geriAlToolStripMenuItem1
            // 
            geriAlToolStripMenuItem1.Name = "geriAlToolStripMenuItem1";
            geriAlToolStripMenuItem1.Size = new Size(116, 22);
            geriAlToolStripMenuItem1.Text = "Geri Al";
            // 
            // kesToolStripMenuItem1
            // 
            kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            kesToolStripMenuItem1.Size = new Size(116, 22);
            kesToolStripMenuItem1.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem1
            // 
            kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            kopyalaToolStripMenuItem1.Size = new Size(116, 22);
            kopyalaToolStripMenuItem1.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem1
            // 
            yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            yapıştırToolStripMenuItem1.Size = new Size(116, 22);
            yapıştırToolStripMenuItem1.Text = "Yapıştır";
            // 
            // silToolStripMenuItem1
            // 
            silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            silToolStripMenuItem1.Size = new Size(116, 22);
            silToolStripMenuItem1.Text = "Sil";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 321);
            Controls.Add(toolStrip1);
            Controls.Add(StatusBar1);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "NotePad Uygulaması";
            StatusBar1.ResumeLayout(false);
            StatusBar1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private StatusStrip StatusBar1;
        private ToolStripStatusLabel lblKaydedildi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem geriAlToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem bulToolStripMenuItem;
        private ToolStripMenuItem yazıTipiToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem1;
        private ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private ToolStripMenuItem solaHizalaToolStripMenuItem;
        private ToolStripMenuItem sağaHizalaToolStripMenuItem;
        private ToolStripMenuItem ortalaToolStripMenuItem;
        private ToolStripMenuItem maddeİşaretleToolStripMenuItem;
        private ToolStripMenuItem araçÇubuğunuGizleToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton11;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem geriAlToolStripMenuItem1;
        private ToolStripMenuItem kesToolStripMenuItem1;
        private ToolStripMenuItem kopyalaToolStripMenuItem1;
        private ToolStripMenuItem yapıştırToolStripMenuItem1;
        private ToolStripMenuItem silToolStripMenuItem1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}