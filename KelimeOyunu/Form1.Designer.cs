namespace KelimeOyunu
{
    partial class oyun
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
            btnBasla = new Button();
            btnGiris = new Button();
            txtKelime = new TextBox();
            lblMesaj = new Label();
            tmrSure = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(64, 12);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(117, 30);
            btnBasla.TabIndex = 0;
            btnBasla.Text = "BAŞLA";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(240, 12);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(117, 30);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtKelime
            // 
            txtKelime.Location = new Point(64, 75);
            txtKelime.Name = "txtKelime";
            txtKelime.Size = new Size(100, 23);
            txtKelime.TabIndex = 2;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(240, 83);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(38, 15);
            lblMesaj.TabIndex = 3;
            lblMesaj.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // oyun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(427, 333);
            Controls.Add(textBox1);
            Controls.Add(lblMesaj);
            Controls.Add(txtKelime);
            Controls.Add(btnGiris);
            Controls.Add(btnBasla);
            Name = "oyun";
            Text = "KELİME OYUNU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBasla;
        private Button btnGiris;
        private TextBox txtKelime;
        private Label lblMesaj;
        private System.Windows.Forms.Timer tmrSure;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}