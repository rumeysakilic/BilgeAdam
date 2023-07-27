namespace Timer
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
            label1 = new Label();
            label2 = new Label();
            txtSure = new TextBox();
            label3 = new Label();
            btnBasla = new Button();
            btnDur = new Button();
            cmbInterval = new ComboBox();
            lbKayit = new ListBox();
            tmrKronometre = new System.Windows.Forms.Timer(components);
            textSure = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 61);
            label1.TabIndex = 0;
            label1.Text = "KRONOMETRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Süreyi Girin(saniye):";
            // 
            // txtSure
            // 
            txtSure.Location = new Point(164, 79);
            txtSure.Name = "txtSure";
            txtSure.Size = new Size(109, 23);
            txtSure.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 79);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "Kalan Süre:";
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(34, 197);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(111, 64);
            btnBasla.TabIndex = 4;
            btnBasla.Text = " BAŞLA";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // btnDur
            // 
            btnDur.Location = new Point(164, 197);
            btnDur.Name = "btnDur";
            btnDur.Size = new Size(109, 64);
            btnDur.TabIndex = 5;
            btnDur.Text = "DUR";
            btnDur.UseVisualStyleBackColor = true;
            btnDur.Click += btnDur_Click;
            // 
            // cmbInterval
            // 
            cmbInterval.FormattingEnabled = true;
            cmbInterval.Items.AddRange(new object[] { "1000", "2000", "3000", "4000", "5000" });
            cmbInterval.Location = new Point(34, 127);
            cmbInterval.Name = "cmbInterval";
            cmbInterval.Size = new Size(239, 23);
            cmbInterval.TabIndex = 6;
            cmbInterval.Text = "Hız Seçin";
            // 
            // lbKayit
            // 
            lbKayit.FormattingEnabled = true;
            lbKayit.ItemHeight = 15;
            lbKayit.Items.AddRange(new object[] { "lbKayıt" });
            lbKayit.Location = new Point(375, 228);
            lbKayit.Name = "lbKayit";
            lbKayit.Size = new Size(203, 94);
            lbKayit.TabIndex = 8;
            // 
            // tmrKronometre
            // 
            tmrKronometre.Tick += tmrKronometre_Tick;
            // 
            // textSure
            // 
            textSure.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textSure.Location = new Point(375, 106);
            textSure.Name = "textSure";
            textSure.Size = new Size(203, 50);
            textSure.TabIndex = 9;
            textSure.Text = "0";
            textSure.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(677, 376);
            Controls.Add(textSure);
            Controls.Add(lbKayit);
            Controls.Add(cmbInterval);
            Controls.Add(btnDur);
            Controls.Add(btnBasla);
            Controls.Add(label3);
            Controls.Add(txtSure);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kronometre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSure;
        private Label label3;
        private Button btnBasla;
        private Button btnDur;
        private ComboBox cmbInterval;
        private ListBox lbKayit;
        private System.Windows.Forms.Timer tmrKronometre;
        private TextBox textSure;
    }
}