namespace KelimeOyunu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new oyun());
            // Uygulaman�n giri� noktas�

            string KullaniciAdi = null;
            KullaniciAdi = Microsoft.VisualBasic.Interaction.InputBox("Kullan�c� Ad� girin: ", "", "", -1, -1);

            if (KullaniciAdi == "")
            {
                return;
            }

            oyun oyun = new oyun();
            oyun.Text = KullaniciAdi + " yar���yor";
            oyun.ShowDialog();
        }
    }
}