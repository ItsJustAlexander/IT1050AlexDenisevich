using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW11_AlexDenisevich
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Given the following code, output element at index 2 and the last element.
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            {
                Console.WriteLine(names[2]);
                Console.WriteLine(names[4]);
            }
            //2. Create a 12-element array called months.
            string[] months = new string[12];

                for (int giveMonth = 0; giveMonth <= 11; giveMonth++)
                {
                    switch (giveMonth)
                    {
                        case 0:
                            months[giveMonth] = "January";
                            break;
                        case 1:
                            months[giveMonth] = "February";
                            break;
                        case 2:
                            months[giveMonth] = "March";
                            break;
                        case 3:
                            months[giveMonth] = "April";
                            break;
                        case 4:
                            months[giveMonth] = "May";
                            break;
                        case 5:
                            months[giveMonth] = "June";
                            break;
                        case 6:
                            months[giveMonth] = "July";
                            break;
                        case 7:
                            months[giveMonth] = "August";
                            break;
                        case 8:
                            months[giveMonth] = "September";
                            break;
                        case 9:
                            months[giveMonth] = "October";
                            break;
                        case 10:
                            months[giveMonth] = "November";
                            break;
                        case 11:
                           months[giveMonth] = "December";
                            break;
                    }
                }
                for (int Month = 0; Month <= 11; Month++)
                {
                    Console.WriteLine(months[Month] + " is " + "month number " + (Month + 1));
                }
            //3.Create a 4-element array to store the names of 4 seasons 
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }   
            //4a.Create an array of integers with 1000 elements 
            Random random = new Random();

            int[] random2 = new int[1000];

            for (int number = 0; number < 1000; number++)
            {
                random2[number] = random.Next(0, 100);
            }
            //4b. Use a foreach loop to output all integers in the array.
            foreach (int Random1 in random2)
            {
                Console.WriteLine(Random1);
            }
            
        }
    }
}
