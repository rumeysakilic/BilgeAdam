namespace IkiliArama
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
            btnAra = new Button();
            lbDizi = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.Location = new Point(198, 98);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 0;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // lbDizi
            // 
            lbDizi.FormattingEnabled = true;
            lbDizi.ItemHeight = 15;
            lbDizi.Location = new Point(12, 27);
            lbDizi.Name = "lbDizi";
            lbDizi.Size = new Size(120, 94);
            lbDizi.TabIndex = 1;
            lbDizi.SelectedIndexChanged += lbDizi_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 27);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 2;
            label1.Text = "Dizide hangi sayıyı aramak istiyorsunuz:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "İndis";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 308);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lbDizi);
            Controls.Add(btnAra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private ListBox lbDizi;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}