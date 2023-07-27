namespace StartPage
{
    partial class Start
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
            button1 = new Button();
            textBox1 = new TextBox();
            goster = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(337, 45);
            button1.Name = "button1";
            button1.Size = new Size(100, 24);
            button1.TabIndex = 0;
            button1.Text = "Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 1;
            // 
            // goster
            // 
            goster.AutoSize = true;
            goster.Location = new Point(84, 106);
            goster.Name = "goster";
            goster.Size = new Size(0, 15);
            goster.TabIndex = 2;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(563, 450);
            Controls.Add(goster);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Start";
            Text = "Start Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label goster;
    }
}