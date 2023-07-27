using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisTopla
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            void MatrisTopla(int[,] matris1, int[,] matris2)
            {
                int x = matris1.GetLength(0);
                int y = matris1.GetLength(1);
                if (x != matris2.GetLength(0) || y != matris2.GetLength(1))
                {
                    Console.WriteLine("Matris boyutlarının büyüklükleri birbiriyle aynı olmalıdır.");

                    return;
                }
                int[,] sonuc = new int[x - 1, y - 1];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        sonuc[i, j] = matris1[i, j] + matris2[i, j];
                    }
                }
            }
            int[,] m1 = { { 1, 3, 5 }, { 7, 9, 11 } };
            int[,] m2 = { { 0, 2, 4 }, { 6, 8, 10 } };
            MatrisTopla(m1, m2);
        }
    }
}