using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.
            int d = 1;
            bool keepLooping = true;
            while (keepLooping)
            {
                if (d <= 0)
                keepLooping = false;d++;
                Console.WriteLine(d);
            }
            
            //2.
            int v = 2;
            while (v <= 128)
            {
                Console.WriteLine("[{0}]", v);
                v *= 2;
            }
            
            //3.
            for (int s = 49; s >= 1; s--)
            {
                Console.Write(s + (s != 1 ? "," : ""));
            }
            Console.WriteLine();

            //4.
            int b = 1;
            while (b <= 21)
            {
                Console.WriteLine(b);
                b = b + 2;
            }
            
            //5.
            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            }
            while (i < n); // test condition
            //while is an entry control loop. The difference is in when the condition gets evaluated. 
            //In a do..while loop, the condition is not evaluated until the end of each loop. 
            //That means that a do..while loop will always run at least once.
            */
            //.6
            bool icyRain = false;
            bool tornadoWarning = false;

            if ((icyRain) & (tornadoWarning))
            {
                Console.WriteLine();
            }
            else if ((!icyRain) && (!tornadoWarning))
            {
                Console.WriteLine("Let's go outside!");
            }
            
            //7. EXTRA CREDIT
            int layers = 5, Space, Number;
            for (int p = 1; p <= layers; p++)
            {
                for (Space = 1; Space <= (layers - p); Space++)
                {
                    Console.Write("");
                }
                for (Number = 1; Number <= p; Number++)
                {
                    Console.Write(Number);
                }
                for (Number = p - 1; Number >= 1; Number--)
                {
                    Console.Write(Number);
                }
                Console.WriteLine();
            }












        }

    }
    
}
