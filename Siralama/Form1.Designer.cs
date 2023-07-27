namespace Siralama
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
            lbSirasiz = new ListBox();
            lbSirali = new ListBox();
            btnListele = new Button();
            btnSirala = new Button();
            SuspendLayout();
            // 
            // lbSirasiz
            // 
            lbSirasiz.FormattingEnabled = true;
            lbSirasiz.ItemHeight = 15;
            lbSirasiz.Location = new Point(12, 56);
            lbSirasiz.Name = "lbSirasiz";
            lbSirasiz.Size = new Size(120, 94);
            lbSirasiz.TabIndex = 0;
            // 
            // lbSirali
            // 
            lbSirali.FormattingEnabled = true;
            lbSirali.ItemHeight = 15;
            lbSirali.Location = new Point(178, 56);
            lbSirali.Name = "lbSirali";
            lbSirali.Size = new Size(120, 94);
            lbSirali.TabIndex = 1;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(12, 176);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 2;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnSirala
            // 
            btnSirala.Location = new Point(178, 176);
            btnSirala.Name = "btnSirala";
            btnSirala.Size = new Size(75, 23);
            btnSirala.TabIndex = 3;
            btnSirala.Text = "Sırala";
            btnSirala.UseVisualStyleBackColor = true;
            btnSirala.Click += btnSirala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 292);
            Controls.Add(btnSirala);
            Controls.Add(btnListele);
            Controls.Add(lbSirali);
            Controls.Add(lbSirasiz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbSirasiz;
        private ListBox lbSirali;
        private Button btnListele;
        private Button btnSirala;
    }
}