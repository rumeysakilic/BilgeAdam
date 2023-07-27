namespace Alarm
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
            btnAlarmKur = new Button();
            groupBox1 = new GroupBox();
            nDakika = new NumericUpDown();
            nSaat = new NumericUpDown();
            nYil = new NumericUpDown();
            nAy = new NumericUpDown();
            nGun = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nDakika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nSaat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            SuspendLayout();
            // 
            // btnAlarmKur
            // 
            btnAlarmKur.Location = new Point(306, 170);
            btnAlarmKur.Name = "btnAlarmKur";
            btnAlarmKur.Size = new Size(112, 23);
            btnAlarmKur.TabIndex = 0;
            btnAlarmKur.Text = "ALARM KUR";
            btnAlarmKur.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nDakika);
            groupBox1.Controls.Add(nSaat);
            groupBox1.Controls.Add(nYil);
            groupBox1.Controls.Add(nAy);
            groupBox1.Controls.Add(nGun);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarih/Saat Ayarla";
            // 
            // nDakika
            // 
            nDakika.Location = new Point(130, 70);
            nDakika.Name = "nDakika";
            nDakika.Size = new Size(39, 23);
            nDakika.TabIndex = 6;
            // 
            // nSaat
            // 
            nSaat.Location = new Point(67, 70);
            nSaat.Name = "nSaat";
            nSaat.Size = new Size(39, 23);
            nSaat.TabIndex = 5;
            // 
            // nYil
            // 
            nYil.Location = new Point(192, 32);
            nYil.Name = "nYil";
            nYil.Size = new Size(48, 23);
            nYil.TabIndex = 4;
            // 
            // nAy
            // 
            nAy.Location = new Point(130, 30);
            nAy.Name = "nAy";
            nAy.Size = new Size(39, 23);
            nAy.TabIndex = 3;
            // 
            // nGun
            // 
            nGun.Location = new Point(67, 30);
            nGun.Name = "nGun";
            nGun.Size = new Size(39, 23);
            nGun.TabIndex = 2;
            nGun.ValueChanged += nGun_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Saat:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Tarih:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 245);
            Controls.Add(groupBox1);
            Controls.Add(btnAlarmKur);
            Name = "Form1";
            Text = "Alarm Kur";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nDakika).EndInit();
            ((System.ComponentModel.ISupportInitialize)nSaat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlarmKur;
        private GroupBox groupBox1;
        private NumericUpDown nDakika;
        private NumericUpDown nSaat;
        private NumericUpDown nYil;
        private NumericUpDown nAy;
        private NumericUpDown nGun;
        private Label label2;
        private Label label1;
    }
}