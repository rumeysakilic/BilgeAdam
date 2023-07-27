using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExmp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] harfler = { "A", "B", "C" };
            Array.Reverse(harfler);
            for (int i = 0; i < harfler.Length; i++)
            {
                Console.Write(harfler[i]);
            }
            Console.WriteLine("");
            string[] harfler1 = { "A", "B", "C" };
            Array.Reverse(harfler, 0, 1);

            float[] notlar = { 78.1f, 99.9f, 100.0f, 12.2f };
            float maxNot = 100;
            Console.WriteLine(Array.IndexOf(notlar, maxNot));
            // Aranan maxNot değerinin indisi = 2
        }
    }
}