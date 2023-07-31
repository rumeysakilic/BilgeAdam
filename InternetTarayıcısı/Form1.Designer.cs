namespace InternetTarayıcısı
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
            LinkLabel1 = new LinkLabel();
            radioButton1 = new RadioButton();
            GroupBox1 = new GroupBox();
            txtAdres = new TextBox();
            btnGit = new Button();
            rbYeniSayfa = new RadioButton();
            label1 = new Label();
            btnSayfaKapat = new Button();
            btnTumunuKapat = new Button();
            tabPage1 = new TabPage();
            TabControl1 = new TabControl();
            GroupBox1.SuspendLayout();
            TabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(428, 22);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(59, 15);
            LinkLabel1.TabIndex = 0;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Ana Sayfa";
            LinkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(60, 63);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Aynı Sayfada";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(txtAdres);
            GroupBox1.Controls.Add(btnGit);
            GroupBox1.Controls.Add(rbYeniSayfa);
            GroupBox1.Controls.Add(label1);
            GroupBox1.Controls.Add(radioButton1);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(358, 100);
            GroupBox1.TabIndex = 2;
            GroupBox1.TabStop = false;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(52, 22);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(219, 23);
            txtAdres.TabIndex = 3;
            txtAdres.Text = "http:// ";
            // 
            // btnGit
            // 
            btnGit.Location = new Point(277, 21);
            btnGit.Name = "btnGit";
            btnGit.Size = new Size(75, 23);
            btnGit.TabIndex = 4;
            btnGit.Text = "Git";
            btnGit.UseVisualStyleBackColor = true;
            btnGit.Click += btnGit_Click;
            // 
            // rbYeniSayfa
            // 
            rbYeniSayfa.AutoSize = true;
            rbYeniSayfa.Location = new Point(178, 63);
            rbYeniSayfa.Name = "rbYeniSayfa";
            rbYeniSayfa.Size = new Size(91, 19);
            rbYeniSayfa.TabIndex = 6;
            rbYeniSayfa.Text = "Yeni Sayfada";
            rbYeniSayfa.UseVisualStyleBackColor = true;
            rbYeniSayfa.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Adres:";
            // 
            // btnSayfaKapat
            // 
            btnSayfaKapat.Location = new Point(394, 41);
            btnSayfaKapat.Name = "btnSayfaKapat";
            btnSayfaKapat.Size = new Size(130, 23);
            btnSayfaKapat.TabIndex = 5;
            btnSayfaKapat.Text = "Sayfayı Kapat";
            btnSayfaKapat.UseVisualStyleBackColor = true;
            btnSayfaKapat.Click += btnSayfaKapat_Click;
            // 
            // btnTumunuKapat
            // 
            btnTumunuKapat.Location = new Point(394, 75);
            btnTumunuKapat.Name = "btnTumunuKapat";
            btnTumunuKapat.Size = new Size(130, 23);
            btnTumunuKapat.TabIndex = 6;
            btnTumunuKapat.Text = "Tüm Sayfaları Kapat";
            btnTumunuKapat.UseVisualStyleBackColor = true;
            btnTumunuKapat.Click += btnTumunuKapat_Click;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(528, 140);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sayfa1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Dock = DockStyle.Bottom;
            TabControl1.Location = new Point(0, 145);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(536, 168);
            TabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 313);
            Controls.Add(TabControl1);
            Controls.Add(btnTumunuKapat);
            Controls.Add(btnSayfaKapat);
            Controls.Add(LinkLabel1);
            Controls.Add(GroupBox1);
            Name = "Form1";
            Text = "Internet Tarayıcısı";
            Load += Form1_Load;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            TabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LinkLabel1;
        private RadioButton radioButton1;
        private GroupBox GroupBox1;
        private Button btnGit;
        private RadioButton rbYeniSayfa;
        private Label label1;
        private TextBox txtAdres;
        private Button btnSayfaKapat;
        private Button btnTumunuKapat;
        private TabPage tabPage1;
        private TabControl TabControl1;
    }
}