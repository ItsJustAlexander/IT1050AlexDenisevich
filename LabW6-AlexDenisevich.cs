using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW6_AlexDenisevich
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two int variables:speedLimit and speed.
            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;
            
            if(speed > speedLimit)
            {
                Console.WriteLine("SLOW DOWN!");
            }
            //Write a program that declares and assigns a value to a Boolean variable called isTrue.  
            // If I put a second bool is True = false; it is saying its an error so all you have to do is change the bool isTrue to false and you will get the else Console.WriteLine("It Is False!)
            bool isTrue = true;
            if (isTrue)
            {
                Console.WriteLine("It Is True!");
            }
            else
            {
                Console.WriteLine("It Is False!");
            }
            //Write a program that converts a Fahrenheit temperature to Celsius. 
            double celsius;

            Console.Write("Enter Fahrenheit temperature :");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("The converted Celsius temperature is " + celsius);

            Console.ReadLine();

            if (fahrenheit < 40)
            {
                Console.WriteLine("It is Cold");
            }
            else if (fahrenheit >= 90)
            {
                Console.WriteLine("It is Hot");
            }
            
            //Write a while loop that outputs values 1-10.  Increment by 1.
            int b;
            b = 1;
            while (b <= 10)
            {
                Console.WriteLine(b);
                b = b + 1;
            }           
            //Write a while loop that outputs values 60 to 20.  Decrement by 1.
            int v;
            v = 60;
            while (v >= 20)
            {
                Console.WriteLine(v);
                v = v - 1;
            }
            
            //Create a while that outputs value 10-20.
            int c;
            c = 10;
            while (c <= 20)
            {
                Console.WriteLine(c);
                c = c + 1;
            }
            
      
        }
    }
}
