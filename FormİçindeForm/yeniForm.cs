using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormİçindeForm
{
    public partial class yeniForm : Form
    {
        public yeniForm()
        {
            InitializeComponent();
        }

        private void yeniForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Shift-Ctrl-F3 tuşları basıldığında uygulama kapanır 
            if (e.Shift & e.Control & e.KeyCode == Keys.F3
           )
            {
                this.Close();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Formun görünmez hale gelince uygulama kapanır 
            if (this.Opacity == 0)
            {
                Application.Exit();
            }
            else
            {
                this.Opacity -= 0.1;
            }
        }
    }
}
