namespace Counter
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
            btnBasla = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnDur = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 27);
            label1.Name = "label1";
            label1.Size = new Size(285, 57);
            label1.TabIndex = 0;
            label1.Text = "Sayacı Başlat";
            // 
            // btnBasla
            // 
            btnBasla.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBasla.Location = new Point(142, 119);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(114, 41);
            btnBasla.TabIndex = 1;
            btnBasla.Text = "BAŞLAT";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnDur
            // 
            btnDur.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDur.Location = new Point(142, 166);
            btnDur.Name = "btnDur";
            btnDur.Size = new Size(114, 41);
            btnDur.TabIndex = 2;
            btnDur.Text = "DURDUR";
            btnDur.UseVisualStyleBackColor = true;
            btnDur.Click += btnDur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(414, 343);
            Controls.Add(btnDur);
            Controls.Add(btnBasla);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sayaç";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBasla;
        private System.Windows.Forms.Timer timer1;
        private Button btnDur;
    }
}