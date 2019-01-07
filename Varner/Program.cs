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
                //else if (c == '2') YL02();
                //else if (c == '3') YL03();
                else break;
            } while (true);
        }

        static void YL01()
        {
            Console.Write("\n\nKorrutustabel (15x15) \n\n");

            int[,] tab = new int[15, 15];

            for (int i = 1; i <= 15; i++)
            {
                for (int j = 1; j <= 15; j++)
                {
                    tab[i - 1, j - 1] = i * j;
                    Console.Write(tab[i - 1, j - 1] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
