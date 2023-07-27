namespace TekSayilar
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
            btnKaydet = new Button();
            label1 = new Label();
            txtAltSayi = new TextBox();
            btnYukle = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUstSayi = new TextBox();
            txtClipBoard = new TextBox();
            label4 = new Label();
            txtSayilar = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(210, 194);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Alt Limit:";
            // 
            // txtAltSayi
            // 
            txtAltSayi.Location = new Point(12, 48);
            txtAltSayi.Name = "txtAltSayi";
            txtAltSayi.Size = new Size(122, 23);
            txtAltSayi.TabIndex = 2;
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(210, 239);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(75, 23);
            btnYukle.TabIndex = 3;
            btnYukle.Text = "Yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Üst Limit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 21);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Tek Sayılar:";
            // 
            // txtUstSayi
            // 
            txtUstSayi.Location = new Point(12, 115);
            txtUstSayi.Name = "txtUstSayi";
            txtUstSayi.Size = new Size(122, 23);
            txtUstSayi.TabIndex = 6;
            txtUstSayi.TextChanged += txtUstSayi_TextChanged;
            // 
            // txtClipBoard
            // 
            txtClipBoard.Location = new Point(12, 194);
            txtClipBoard.Multiline = true;
            txtClipBoard.Name = "txtClipBoard";
            txtClipBoard.Size = new Size(122, 95);
            txtClipBoard.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "ClipBoard";
            // 
            // txtSayilar
            // 
            txtSayilar.Location = new Point(186, 48);
            txtSayilar.Multiline = true;
            txtSayilar.Name = "txtSayilar";
            txtSayilar.Size = new Size(122, 90);
            txtSayilar.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(354, 301);
            Controls.Add(txtSayilar);
            Controls.Add(label4);
            Controls.Add(txtClipBoard);
            Controls.Add(txtUstSayi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnYukle);
            Controls.Add(txtAltSayi);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Name = "Form1";
            Text = "Tek Sayılar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private TextBox txtAltSayi;
        private Button btnYukle;
        private Label label2;
        private Label label3;
        private TextBox txtUstSayi;
        private TextBox txtClipBoard;
        private Label label4;
        private TextBox txtSayilar;
    }
}