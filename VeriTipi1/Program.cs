using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeriTipi1
{
    internal class Program
    {
        public struct Nokta
        {
            public int x;
            public int y;

            public void Degistir(int yeniX, int yeniY)
            {
                x = yeniX;
                y = yeniY;
            }
        }

        private static void Main(string[] args)
        {
            Nokta nokta = new Nokta();
            nokta.Degistir(25, 45);
            Console.WriteLine(nokta.x + " " + nokta.y);
        }
    }
}