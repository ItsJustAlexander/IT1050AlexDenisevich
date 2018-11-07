using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW8_AlexDenisevich
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            int b; //counter
            b = 1;
            while (b < 10) //condition
            {
                Console.WriteLine(b); //loop control variable
                b = b + 2;
            }
            //2.
            int i;
            for (i = 35; i <= 45; i = i + 1)
            {
                Console.WriteLine(i);
            }
            if ((i % 2) == 0)
            {
                Console.WriteLine("Its Even");
            }
            else if ((i % 2) != 0)
            {
                Console.WriteLine("Its odd");
            }

            //4.
            int v;
            v = 10;
            while (v < 21)
            {
                Console.WriteLine(v);
                v = v + 1; // they forgot to add this line into there code without 
                           // this code the program run the number 10 forever.
            }
            //5.
            for (int y = 0; y < 101; y++)
            {
                Console.WriteLine(y);
                Console.WriteLine("********");
            }
            // they didnt put the bracket symbol {}. To run the program that you are asking it to do, you need 
            // add brackets before and after your Console.WriteLines.

            //3.
            int militaryTime;
            while (true)
            {
                Console.WriteLine("Enter the time in military time");
                militaryTime = Convert.ToInt32(Console.ReadLine());

                if (militaryTime < 11)
                {
                    Console.WriteLine("Good Morning");
                }
                else if (militaryTime == 12 || militaryTime <= 16)
                {
                    Console.WriteLine("Good Afternoon");
                }
                else 
                {
                    Console.WriteLine("Good Evening");
                }

            }

        }
    }
}