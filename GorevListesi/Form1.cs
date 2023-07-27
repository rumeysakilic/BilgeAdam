using System.Windows.Forms;

namespace GorevListesi
{
    public partial class Form1 : Form
    {
        public class Gorev
        {
            public string GorevIsmi;
            public DateTime BaslangicTarihi;
            public DateTime BitisTarihi;

            // Liste kontrollerinde görevin isminin görüntülenmesi
            // için, ToString metodunu tekrar yazmak gerekir.
            public override string ToString()
            {
                return GorevIsmi;
            }

            public Gorev(string Isim, DateTime basTarihi, DateTime bitTarihi)
            {
                this.GorevIsmi = Isim;
                this.BaslangicTarihi = basTarihi;
                this.BitisTarihi = bitTarihi;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Maksimum iki hafta seçilsin
            monthCalendar1.MaxSelectionCount = 14;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = monthCalendar1.SelectionStart;
            DateTime bitisTarihi = monthCalendar1.SelectionEnd;
            string gorevIsmi = txtYeniGorev.Text;

            Gorev yeniGorev = new Gorev(gorevIsmi, baslangicTarihi, bitisTarihi);
            listBox1.Items.Add(yeniGorev);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gorev secilen;
            secilen = (Gorev)listBox1.SelectedItem;

            monthCalendar1.SelectionStart = secilen.BaslangicTarihi;
            monthCalendar1.SelectionEnd = secilen.BitisTarihi;
            txtYeniGorev.Text = secilen.GorevIsmi;
        }
    }
}