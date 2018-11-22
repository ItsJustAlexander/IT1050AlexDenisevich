using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_AlexDenisevich
{
    class MyMath //this is the class
    {
        public double a;
        public double b;
        public double result;
        public string operation;
        public string output;

        public MyMath(double operand1, double operand2)
        {
            a = operand1;
            b = operand2;
        }
        public void Multiply()
        {
            result = a * b;
            operation = "multiply";
        }
        public void Divide()
        {
            result = a / b;
            operation = "divide";
        }
        public void Subtract()
        {
            result = a - b;
            operation = "subtract";
        }
        public void Add()
        {
            result = a + b;
            operation = "add";
        }
        public void GetResult()
        {
            switch (operation)
            {
                case "multiply":
                    output = a + " * " + b + " = " + result;
                    break;
                case "divide":
                    output = a + " / " + b + " = " + result;
                    break;
                case "add":
                    output = a + " + " + b + " = " + result;
                    break;
                case "subtract":
                    output = a + " - " + b + " = " + result;
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
//this is the program code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_AlexDenisevich
{
    class Program
    {
        static void Main(string[] args)
        {
            double op1;
            double op2;

            Console.Write("Enter operand1 amount: ");
            op1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operand2 amount: ");
            op2 = Convert.ToDouble(Console.ReadLine());

            var myResult = new MyMath(op1, op2);

            myResult.Multiply();
            myResult.GetResult();

            myResult.Divide();
            myResult.GetResult();

            myResult.Subtract();
            myResult.GetResult();

            myResult.Add();
            myResult.GetResult();

            
            
        }
    }
}

