using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBOB
{
    internal class Program
    {
        public static int EBOB(int sayi1, int sayi2)
        {
            while (sayi2 != 0)
            {
                int gecici = sayi2;
                sayi2 = sayi1 % sayi2;
                sayi1 = gecici;
            }
            return sayi1;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int ebob = EBOB(sayi1, sayi2);
            Console.WriteLine("Girdiğiniz sayıların EBOB'u : " + ebob);
        }
    }
}