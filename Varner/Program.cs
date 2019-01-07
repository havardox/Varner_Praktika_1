using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varner
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Vajuta ülesande number:");
                Console.WriteLine("1 - Korrutustabel (15x15)");
                Console.WriteLine("2 - Ülesanne 2");
                Console.WriteLine("3 - Ülesanne 3");
                char c = Console.ReadKey().KeyChar;
                if (c == '1') YL01();
                else if (c == '2') YL02();
                //else if (c == '3') YL03();
                else break;
            } while (true);
        }

        static void YL01()
        {
            Console.Write("\n\nKorrutustabel (15x15) \n\n");

            int[,] tab = new int[16, 16];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    tab[i, j] = i * j;
                    Console.Write("{0,4}",tab[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void YL02()
        {
            Console.Write("\n\nÜlesanne 2 \n\n");
            // Formeerida kahemõõtmeline massiiv 10x10
            // juhuarvudest vahemikust [10,99]
            // Diagonaalid on 0
            // ja leida selle massiivi maksimaalsete arvude asukohad.
            Random rand = new Random();
            int[,] tab = new int[10,10];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    tab[i, j] = rand.Next(10, 100);
                }
                tab[i, i] = 0;
                tab[i, tab.GetLength(1) - 1 - i] = 0;
            }

            PrintMatrix(tab);

            int max = tab[0, 0];
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (tab[i, j] > max)
                    {
                        max = tab[i, j];
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    Console.Write("{0,4}", tab[i, j]);
                }
                Console.WriteLine("");
                for (j = 0; j < 10; j++)
                {
                    if (tab[i,j] == max)
                    {
                        Console.Write("  --");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine("");
            }
        }

        static void PrintMatrix(int[,] arr)
        {
            int numLines = arr.GetLength(0);
            int numCols = arr.GetLength(1);
            Console.Write("Matrix {0}x{1} väljatrükk\n\n", numLines, numCols);
            for (int i = 0; i < numLines; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
