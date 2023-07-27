namespace Butonİslemleri
{
    public partial class OnayFormu : Form
    {
        public OnayFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnayFormu onay = New OnayFormu();
            onay.btnHayir.DialogResult = DialogResult.No;
            onay.FlatStyle = FlatStyle.Flat;
            onay.btnEvet.DialogResult = DialogResult.Yes;
            onay.btnEvet.FlatStyle = FlatStyle.Flat;
            if (onay.ShowDialog == DialogResult.Yes)
           // Kayıt işlemleri... 
        }
    }
}