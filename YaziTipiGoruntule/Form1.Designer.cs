namespace YaziTipiGoruntule
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
            lblYaziTipiSec = new Label();
            dFont = new DomainUpDown();
            textBox1 = new TextBox();
            hScrollBar1 = new HScrollBar();
            SuspendLayout();
            // 
            // lblYaziTipiSec
            // 
            lblYaziTipiSec.AutoSize = true;
            lblYaziTipiSec.Location = new Point(12, 25);
            lblYaziTipiSec.Name = "lblYaziTipiSec";
            lblYaziTipiSec.Size = new Size(83, 15);
            lblYaziTipiSec.TabIndex = 0;
            lblYaziTipiSec.Text = "Yazı Tipi Seçin:";
            // 
            // dFont
            // 
            dFont.Location = new Point(155, 23);
            dFont.Name = "dFont";
            dFont.Size = new Size(120, 23);
            dFont.TabIndex = 1;
            dFont.Text = "domainUpDown1";
            dFont.SelectedItemChanged += dFont_SelectedItemChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 106);
            textBox1.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(12, 181);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(263, 16);
            hScrollBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 234);
            Controls.Add(hScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(dFont);
            Controls.Add(lblYaziTipiSec);
            Name = "Form1";
            Text = "Yazı Tipi Görüntüle";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYaziTipiSec;
        private DomainUpDown dFont;
        private TextBox textBox1;
        private HScrollBar hScrollBar1;
    }
}