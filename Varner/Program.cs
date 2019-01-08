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
                Console.WriteLine("4 - Ülesanne 4");
                Console.WriteLine("5 - Ülesanne 5");
                Console.WriteLine("6 - Ülesanne 6");
                char c = Console.ReadKey().KeyChar;
                if (c == '1') YL01();
                else if (c == '2') YL02();
                else if (c == '3') YL03();
                else if (c == '4') YL04();
                else if (c == '5') YL05();
                else if (c == '6') YL06();
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

        static void YL03()
        {
            // Formeerida kahemõõtmeline massiiv 15x20 vahemikust [10,50]
            // Trükkida see massiiv.
            // Formeerida uus massiiv, kus iga rea arvud on tagurpidi
            Console.Write("\n\nÜlesanne 3 \n\n");
            Random rand = new Random();
            int[,] tab = new int[10, 20];
            int[,] tab2 = new int[10, 20];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    tab[i, j] = rand.Next(10, 51);
                }
            }
            PrintMatrix(tab);
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 20; j++)
                {
                   tab2[i, j] = tab[i, tab.GetLength(1) - j - 1];
                }
            }
            PrintMatrix(tab2);
        }

        static void YL04()
        {
            int number;
            double S;
            S = 0;
            number = (int) InputInteger();
            Console.Write("S = ");
            for (int i=1; i<=number; i++)
            {
                if (i == 1) {
                    S += i + i;
                }
                else
                {
                    S /= i + i;
                }
                Console.Write("{0} + {0}", i);
                if (i != number)
                {
                    Console.Write(" / ");
                }
            }
            S += (number - 1) / number;
            Console.Write(" + ({0} - 1) / {0} = {1}\n\n", number, S);
        }

        static double InputInteger()
        {
            int input;
            while (true)
            {
                Console.Write("\nSisestage täisarv: ");
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Ei ole täisarv");
                }
                else
                {
                    return input;
                }
            }
        }

        static void YL05()
        {
            int number, cellValue;
            number = (int) InputInteger();
            int[,] tab = new int[number, number];
            for (int i = 0; i < number; i++)
            {
                cellValue = 1;
                for (int j = 0; j < number; j++)
                {
                    tab[i, j] = cellValue;
                    cellValue += 2;
                }
            }
            PrintMatrix(tab);
        }

        static void YL06()
        {
            string sentence;
            char previousCharacter = ' ';
            int wordCount = 0;
            Console.WriteLine("\nSisestage lasue:");
            sentence = Console.ReadLine();
            for(int i = 0; i < (sentence.Length - 1); i++)
            {
                if (i != 0)
                {
                    if (sentence[i] != ' ')
                    {
                        if (previousCharacter == ' ')
                        {
                            wordCount += 1;
                            Console.WriteLine(sentence[i]);
                        }
                    }

                    previousCharacter = sentence[i];
                }
            }
            Console.WriteLine("Sõnad: {0}", wordCount);
        }
    }
}
