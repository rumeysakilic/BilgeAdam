namespace ProgressBar
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
            lblHiz = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // lblHiz
            // 
            lblHiz.AutoSize = true;
            lblHiz.Location = new Point(21, 28);
            lblHiz.Name = "lblHiz";
            lblHiz.Size = new Size(27, 15);
            lblHiz.TabIndex = 0;
            lblHiz.Text = "Hız:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(146, 66);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 2;
            button1.Text = "Sayımı Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(138, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Durumu Göster";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 202);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblHiz);
            Name = "Form1";
            Text = "Sayım";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHiz;
        private TextBox textBox1;
        private Button button1;
        private CheckBox checkBox1;
    }
}