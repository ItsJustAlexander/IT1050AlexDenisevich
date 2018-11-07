using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Part2_AlexDenisevich
{
    class Program
    {
        const string STAR = "*";
        const string SPACE = " ";
        const int COUNTER = 10;
        
        static void Main(string[] args)
        {
            DisplayA();

            Console.WriteLine();

        }
        static public void DisplayA()
        {
            for (int r = 0; r < COUNTER; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    Console.Write(STAR);
                }
                Console.WriteLine();
            }
        }
    }
}
