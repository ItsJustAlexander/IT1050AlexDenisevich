using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW4_AlexDenisevich
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accept 2 inputs from the command prompt.  Output their sum.
            decimal dAmount1;
            decimal dAmount2;
            decimal dSum;

            Console.WriteLine("Enter the amount for the first number");
            dAmount1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount for the second number");
            dAmount2 = decimal.Parse(Console.ReadLine());

            dSum = dAmount1 + dAmount2;

            Console.WriteLine("The sum of {0:C} + {1:C} is {2:C}", dAmount1, dAmount2, dSum);

             // Create 3 variables: x, y and z. Assign integer values to them.
             // Output the solution to the following expression: (x + y) * (z + 10) 
             int x;
             int y;
             int z;
             int sum;
            Console.WriteLine("This is the sum of the variables when I input them into the expression is");
             x = 5;
             y = 10;
             z = 7;
             sum = (x + y) * (z + 10);

            Console.WriteLine(sum);

            Console.WriteLine("These are the four outputs using escape sequences");
            //Output 1
            Console.WriteLine("Hello\tWorld!");
            //Output2
            Console.WriteLine("Hello\nWorld");
            //Output3
            Console.WriteLine("\"HelloWorld!\"");
            //Output4
            Console.WriteLine("Hello\\World!");


        }
    }
}
