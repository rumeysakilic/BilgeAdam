namespace Satranç
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
            btnGoster = new Button();
            lbHareketAlani = new ListBox();
            txtFilinXKoordinati = new TextBox();
            txtFilinYKoordinati = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(40, 127);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(75, 23);
            btnGoster.TabIndex = 1;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // lbHareketAlani
            // 
            lbHareketAlani.FormattingEnabled = true;
            lbHareketAlani.ItemHeight = 15;
            lbHareketAlani.Location = new Point(23, 12);
            lbHareketAlani.Name = "lbHareketAlani";
            lbHareketAlani.Size = new Size(120, 94);
            lbHareketAlani.TabIndex = 2;
            // 
            // txtFilinXKoordinati
            // 
            txtFilinXKoordinati.Location = new Point(253, 12);
            txtFilinXKoordinati.Name = "txtFilinXKoordinati";
            txtFilinXKoordinati.Size = new Size(100, 23);
            txtFilinXKoordinati.TabIndex = 3;
            // 
            // txtFilinYKoordinati
            // 
            txtFilinYKoordinati.Location = new Point(253, 83);
            txtFilinYKoordinati.Name = "txtFilinYKoordinati";
            txtFilinYKoordinati.Size = new Size(100, 23);
            txtFilinYKoordinati.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(149, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 5;
            label1.Text = "Filin X koordinatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(149, 91);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "Filin Y koordinatı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(438, 335);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFilinYKoordinati);
            Controls.Add(txtFilinXKoordinati);
            Controls.Add(lbHareketAlani);
            Controls.Add(btnGoster);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoster;
        private ListBox lbHareketAlani;
        private TextBox txtFilinXKoordinati;
        private TextBox txtFilinYKoordinati;
        private Label label1;
        private Label label2;
    }
}