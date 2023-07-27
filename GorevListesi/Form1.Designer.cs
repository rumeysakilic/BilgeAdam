namespace GorevListesi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtYeniGorev = new TextBox();
            btnEkle = new Button();
            monthCalendar1 = new MonthCalendar();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Tarih Seçin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 24);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Tüm Görevler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Yeni Görev İsmi:";
            // 
            // txtYeniGorev
            // 
            txtYeniGorev.Location = new Point(5, 277);
            txtYeniGorev.Name = "txtYeniGorev";
            txtYeniGorev.Size = new Size(154, 23);
            txtYeniGorev.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(84, 319);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(5, 48);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(260, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 154);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 355);
            Controls.Add(listBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(btnEkle);
            Controls.Add(txtYeniGorev);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYeniGorev;
        private Button btnEkle;
        private MonthCalendar monthCalendar1;
        private ListBox listBox1;
    }
}