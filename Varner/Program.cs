using System;
using System.Collections.Generic;

namespace Varner
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Write("Vajuta ülesande number:\n");
                Console.Write("1 - Korrutustabel (15x15)\n");
                Console.Write("2 - Ülesanne 2\n");
                Console.Write("3 - Ülesanne 3\n");
                Console.Write("4 - Ülesanne 4\n");
                Console.Write("5 - Ülesanne 5\n");
                Console.Write("6 - Ülesanne 6\n");
                Console.Write("7 - Ülesanne 7\n");
                Console.Write("8 - Ülesanne 8\n");
                Console.Write("9 - Ülesanne 9\n");
                Console.Write("10 - Ülesanne 10\n");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    YL01();
                }
                else if (input == "2")
                {
                    YL02();
                }
                else if (input == "3")
                {
                    YL03();
                }
                else if (input == "4")
                {
                    YL04();
                }
                else if (input == "5")
                {
                    YL05();
                }
                else if (input == "6")
                {
                    YL06();
                }
                else if (input == "7")
                {
                    YL07();
                }
                else if (input == "8")
                {
                    YL08();
                }
                else if (input == "9")
                {
                    YL09();
                }
                else if (input == "10")
                {
                    YL10();
                }
                else
                {
                    break;
                }
            }
            while (true);
        }

        static void YL01()
        {
            Console.Write("\n\n Korrutustabel (15x15) \n\n");
            int[,] tab = new int[16, 16];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    tab[i, j] = i * j;
                }
            }

            PrintMatrix(tab);
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

                Console.Write("\n");
            }

            Console.Write("\n");
        }

        static void YL02()
        {
            // Formeerida kahemõõtmeline massiiv 10x10
            // juhuarvudest vahemikust [10,99]
            // Diagonaalid on 0
            // ja leida selle massiivi maksimaalsete arvude asukohad.
            Console.Write("\n\n Ülesanne 2 \n\n");
            int[,] tab = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = rand.Next(10, 100);
                }

                tab[i, i] = 0;
                tab[i, tab.GetLength(1) - 1 - i] = 0;
            }

            int max = tab[0, 0];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (tab[i, j] > max)
                    {
                        max = tab[i, j];
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0,4}", tab[i, j]);
                }
                
                Console.Write("\n");
                for (int j = 0; j < 10; j++)
                {
                    if (tab[i, j] == max )
                    {
                        Console.Write("  --");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }

                Console.Write("\n");
            }
        }

        static void YL03()
        {
            // Formeerida kahemõõtmeline massiiv 15x20 vahemikust [10,50]
            // Trükkida see massiiv.
            // Formeerida uus massiiv, kus iga rea arvud on tagurpidi
            Console.Write("\n\n Ülesanne 3 \n\n");
            Random rand = new Random();
            int[,] tab = new int[10, 20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    tab[i, j] = rand.Next(10, 51);
                }
            }

            PrintMatrix(tab);
            int[,] tab2 = new int[10, 20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                   tab2[i, j] = tab[i, tab.GetLength(1) - j - 1];
                }
            }

            PrintMatrix(tab2);
        }

        static void YL04()
        {
            Console.Write("\n\n Ülesanne 4 \n\n");
            int number = InputInteger("Sisesta täisarv: ");
            double result = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i == 1)
                {
                    result += i * 2;
                }
                else 
                {
                    result /= i + i;
                }

                Console.Write("{0} + {0}", i);
                if (i != number)
                {
                    Console.Write(" / ");
                }
            }

            result += (number - 1) / (float)number;
            Console.Write(" + ({0} - 1) / {0} = {1}\n\n", number, result);
        }

        static int InputInteger(string text)
        {
            while (true)
            {
                Console.Write(text);
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.Write("Ei ole täisarv\n");
                }
                else
                {
                    return input;
                }
            }
        }

        static void YL05()
        {
            Console.Write("\n\n Ülesanne 5 \n\n");
            int number = InputInteger("Sisesta täisarv: ");
            int[,] tab = new int[number, number];
            for (int i = 0; i < number; i++)
            {
                int cellValue = 1;
                for (int j = 0; j < number; j++)
                {
                    tab[i, j] = cellValue;
                    cellValue += 2;
                }
            }

            Console.Write("\n");
            PrintMatrix(tab);
        }

        static void YL06()
        {
            Console.Write("\n\n Ülesanne 6 \n\n");
            Console.Write("Sisesta lause:\n");
            string str = Console.ReadLine();
            str = " " + str + " ";
            int wordCount = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ' && str[i] != ' ')
                {
                    wordCount++;
                }
            }

            Console.Write("\nSõnade arv on " + wordCount + "\n\n");
            Console.Write("[");
            str += "*";
            string[] words = new string[wordCount];
            int k = 0;
            int l = 0;
            while (true)
            {
                while (str[l] == ' ')
                {
                    l++;
                }

                if (l == (str.Length - 1))
                {
                    Console.Write("]\n\n");
                    break;
                }

                if (k != 0)
                {
                    Console.Write(", ");
                }

                while (str[l] != ' ')
                {
                    words[k] += str[l];
                    l++;
                }

                Console.Write(words[k]);
                k++;
            }

            for (int i = 0; i < (wordCount - 1); i++)
            {
                for (int j = i + 1; j < wordCount; j++)
                {
                    if (words[j].Length < words[i].Length)
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }

            string newText = string.Empty;
            for (int i = 0; i < wordCount; i++)
            {
                newText += words[i] + " ";
            }

            Console.Write(newText + "\n\n");
        }

        static void YL07()
        {
            Console.Write("\n\n BIN TO DEC \n\n");
            Console.Write("Sisesta kahendarv: ");
            string text = Console.ReadLine();
            int decNumber = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                int binDigit = text[i] - '0';

                decNumber += decNumber * 2 + binDigit;
            }

            Console.Write("\nKümnendarv = {0}\n\n", decNumber);
        }

        static void YL08()
        {
            Console.Write("\n\n HEX TO DEC \n\n");
            Console.Write("Sisesta 16-arv: ");
            string text = Console.ReadLine();
            int decNumber = 0, hexDigit = 0;
            bool error = false;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= '0' && c <= '9')
                {
                    hexDigit = c - '0';
                }
                else if (c >= 'A' && c <= 'F')
                {
                    hexDigit = c - 'A' + 10;
                }
                else if (c >= 'a' && c <= 'f')
                {
                    hexDigit = c - 'a' + 10;
                }
                else
                {
                    error = true;
                }

                decNumber = decNumber * 16 + hexDigit;
            }

            if (error)
            {
                Console.Write("\nViga\n\n");
            }
            else
            {
                Console.Write("\nKümnendarv = {0}\n\n", decNumber);
            }
        }

        static void YL09()
        {
            Console.Write("\n\n DEC TO OCT\n\n");
            int decNumber = InputInteger("Sisesta kümnendarv: ");
            string octNumber = "";
            do
            {
                string c = (decNumber % 8).ToString();
                octNumber = c + octNumber;
                decNumber /= 8;
            } while (decNumber > 0);

            Console.Write("\nOCT arv = {0}\n\n", octNumber);
        }

        static void YL10()
        {
            Console.Write("\n\n DEC TO OCT\n\n");
            int decNumber = InputInteger("Sisesta kümnendarv: ");
            string hexNumber = "";
            char c;
            do
            {
                int i = decNumber % 16;
                if (i < 10)
                {
                    c = (char)('0' + i);
                }
                else
                {
                    c = (char)('A' + i - 10);
                }

                hexNumber = c + hexNumber;
                decNumber /= 16;
            } while (decNumber > 0);

            Console.Write("\nOCT arv = {0}\n\n", hexNumber);
        }
    }
}