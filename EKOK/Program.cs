using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKOK
{
    internal class Program
    {
        public static int EKOK(int sayi1, int sayi2)
        {
            int buyukSayi = Math.Max(sayi1, sayi2);
            int kucukSayi = Math.Min(sayi1, sayi2);
            int ekok = buyukSayi;

            while (true)
            {
                if (ekok % kucukSayi == 0)
                    return ekok;

                ekok += buyukSayi;
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int ekok = EKOK(sayi1, sayi2);
            Console.WriteLine("Girdiğiniz sayıların EKOK'u : " + ekok);
        }
    }
}