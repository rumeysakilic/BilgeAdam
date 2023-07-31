namespace SayıTahminiOyunu
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
            ListBox1 = new ListBox();
            DomainUpDown1 = new DomainUpDown();
            errorProvider1 = new ErrorProvider(components);
            txtTahmin = new TextBox();
            btnTahminEt = new Button();
            YeniOyun = new Button();
            label1 = new Label();
            lblMesaj = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(246, 15);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(120, 139);
            ListBox1.TabIndex = 0;
            // 
            // DomainUpDown1
            // 
            DomainUpDown1.Items.Add("Farklı Sayılar");
            DomainUpDown1.Items.Add("Tekrarlı Sayılar");
            DomainUpDown1.Location = new Point(12, 126);
            DomainUpDown1.Name = "DomainUpDown1";
            DomainUpDown1.Size = new Size(120, 23);
            DomainUpDown1.TabIndex = 1;
            DomainUpDown1.Text = "Zorluk Seçin";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(67, 15);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(157, 23);
            txtTahmin.TabIndex = 2;
            txtTahmin.Validating += txtTahmin_Validating;
            // 
            // btnTahminEt
            // 
            btnTahminEt.Location = new Point(149, 58);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(75, 23);
            btnTahminEt.TabIndex = 3;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // YeniOyun
            // 
            YeniOyun.Location = new Point(149, 124);
            YeniOyun.Name = "YeniOyun";
            YeniOyun.Size = new Size(75, 23);
            YeniOyun.TabIndex = 4;
            YeniOyun.Text = "Yeni Oyun";
            YeniOyun.UseVisualStyleBackColor = true;
            YeniOyun.Click += YeniOyun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Tahmin:";
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(23, 208);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(38, 15);
            lblMesaj.TabIndex = 6;
            lblMesaj.Text = "Mesaj";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 249);
            Controls.Add(lblMesaj);
            Controls.Add(label1);
            Controls.Add(YeniOyun);
            Controls.Add(btnTahminEt);
            Controls.Add(txtTahmin);
            Controls.Add(DomainUpDown1);
            Controls.Add(ListBox1);
            Name = "Form1";
            Text = "Sayı Tahmini Oyunu";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBox1;
        private DomainUpDown DomainUpDown1;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Button YeniOyun;
        private Button btnTahminEt;
        private TextBox txtTahmin;
        private Label lblMesaj;
    }
}