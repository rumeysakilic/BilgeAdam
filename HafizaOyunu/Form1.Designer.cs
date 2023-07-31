namespace HafizaOyunu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            ımageList1 = new ImageList(components);
            ımageList2 = new ImageList(components);
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "4 Kart", "8 Kart", "16 Kart" });
            comboBox1.Location = new Point(113, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Daffy_Duck - Copy.png");
            ımageList1.Images.SetKeyName(1, "Daffy_Duck.png");
            ımageList1.Images.SetKeyName(2, "helloKitty - Copy.png");
            ımageList1.Images.SetKeyName(3, "helloKitty.png");
            ımageList1.Images.SetKeyName(4, "husky - Copy.jpg");
            ımageList1.Images.SetKeyName(5, "husky.jpg");
            ımageList1.Images.SetKeyName(6, "mickey-mouse - Copy.jpg");
            ımageList1.Images.SetKeyName(7, "mickey-mouse.jpg");
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth8Bit;
            ımageList2.ImageSize = new Size(16, 16);
            ımageList2.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 289);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Hafıza Oyunu";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ImageList ımageList1;
        private ImageList ımageList2;
    }
}