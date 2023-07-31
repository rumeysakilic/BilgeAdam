namespace MenuKullanimi
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            MenuItem = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniDosyaAçToolStripMenuItem = new ToolStripMenuItem();
            dosyaAçToolStripMenuItem = new ToolStripMenuItem();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            kapatToolStripMenuItem = new ToolStripMenuItem();
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            araToolStripMenuItem = new ToolStripMenuItem();
            googleİleAraToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            contextMenuStrip2 = new ContextMenuStrip(components);
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblNumLock = new ToolStripStatusLabel();
            lblCapsLock = new ToolStripStatusLabel();
            lblKarakterUzunlugu = new ToolStripStatusLabel();
            richTextBox1 = new RichTextBox();
            notifyIcon1 = new NotifyIcon(components);
            MenuItem.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MenuItem
            // 
            MenuItem.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenleToolStripMenuItem, görünümToolStripMenuItem, yardımToolStripMenuItem, araToolStripMenuItem });
            MenuItem.Location = new Point(0, 0);
            MenuItem.Name = "MenuItem";
            MenuItem.Size = new Size(382, 24);
            MenuItem.TabIndex = 1;
            MenuItem.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniDosyaAçToolStripMenuItem, dosyaAçToolStripMenuItem, ekleToolStripMenuItem, kapatToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniDosyaAçToolStripMenuItem
            // 
            yeniDosyaAçToolStripMenuItem.Image = Properties.Resources.s;
            yeniDosyaAçToolStripMenuItem.Name = "yeniDosyaAçToolStripMenuItem";
            yeniDosyaAçToolStripMenuItem.Size = new Size(148, 22);
            yeniDosyaAçToolStripMenuItem.Text = "Yeni Dosya Aç";
            // 
            // dosyaAçToolStripMenuItem
            // 
            dosyaAçToolStripMenuItem.Image = Properties.Resources.s;
            dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            dosyaAçToolStripMenuItem.Size = new Size(148, 22);
            dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Image = Properties.Resources.s;
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(148, 22);
            ekleToolStripMenuItem.Text = "Ekle";
            // 
            // kapatToolStripMenuItem
            // 
            kapatToolStripMenuItem.Image = Properties.Resources.kapat;
            kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            kapatToolStripMenuItem.Size = new Size(148, 22);
            kapatToolStripMenuItem.Text = "Kapat";
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(61, 20);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(70, 20);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(56, 20);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // araToolStripMenuItem
            // 
            araToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { googleİleAraToolStripMenuItem });
            araToolStripMenuItem.Name = "araToolStripMenuItem";
            araToolStripMenuItem.Size = new Size(37, 20);
            araToolStripMenuItem.Text = "Ara";
            // 
            // googleİleAraToolStripMenuItem
            // 
            googleİleAraToolStripMenuItem.Name = "googleİleAraToolStripMenuItem";
            googleİleAraToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            googleİleAraToolStripMenuItem.Size = new Size(192, 22);
            googleİleAraToolStripMenuItem.Text = "Google ile ara";
            googleİleAraToolStripMenuItem.ToolTipText = "Google git";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(382, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.s;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.kapat;
            toolStripButton2.ImageTransparentColor = Color.Thistle;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { kopyalaToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(117, 26);
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(116, 22);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblNumLock, lblCapsLock, lblKarakterUzunlugu });
            statusStrip1.Location = new Point(0, 232);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(382, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblNumLock
            // 
            lblNumLock.Name = "lblNumLock";
            lblNumLock.Size = new Size(59, 17);
            lblNumLock.Text = "NumLock";
            // 
            // lblCapsLock
            // 
            lblCapsLock.Name = "lblCapsLock";
            lblCapsLock.Size = new Size(58, 17);
            lblCapsLock.Text = "CapsLock";
            // 
            // lblKarakterUzunlugu
            // 
            lblKarakterUzunlugu.Name = "lblKarakterUzunlugu";
            lblKarakterUzunlugu.Size = new Size(107, 17);
            lblKarakterUzunlugu.Text = "Karakter  Uzunluğu";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(370, 180);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 254);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(MenuItem);
            MainMenuStrip = MenuItem;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MenuItem.ResumeLayout(false);
            MenuItem.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip MenuItem;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem yeniDosyaAçToolStripMenuItem;
        private ToolStripMenuItem dosyaAçToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem kapatToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem araToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem googleİleAraToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblNumLock;
        private ToolStripStatusLabel lblCapsLock;
        private ToolStripStatusLabel lblKarakterUzunlugu;
        private RichTextBox richTextBox1;
        private NotifyIcon notifyIcon1;
    }
}