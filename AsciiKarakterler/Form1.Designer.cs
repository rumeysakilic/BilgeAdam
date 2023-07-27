namespace AsciiKarakterler
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
            listBox1 = new ListBox();
            btn_goruntule = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(103, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 139);
            listBox1.TabIndex = 0;
            // 
            // btn_goruntule
            // 
            btn_goruntule.Location = new Point(103, 248);
            btn_goruntule.Name = "btn_goruntule";
            btn_goruntule.Size = new Size(145, 23);
            btn_goruntule.TabIndex = 1;
            btn_goruntule.Text = "GÖRÜNTÜLE";
            btn_goruntule.UseVisualStyleBackColor = true;
            btn_goruntule.Click += btn_goruntule_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(269, 76);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(141, 139);
            listBox2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(542, 344);
            Controls.Add(listBox2);
            Controls.Add(btn_goruntule);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btn_goruntule;
        private ListBox listBox2;
    }
}