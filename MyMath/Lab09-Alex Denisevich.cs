using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLab_Alex_Denisevich
{
    class Program
    {
        static void Main(string[] args)
        {

            MyMath GetResultMultiply = new MyMath();
            MyMath GetResultDivide = new MyMath();
            MyMath GetResultSubtract = new MyMath();
            MyMath GetResultAdd = new MyMath();

            GetResultMultiply.Multiply(5, 5);
            GetResultDivide.Divide(45, 5);
            GetResultSubtract.Subtract(21, 9);
            GetResultAdd.Add(55, 45);

            Console.WriteLine(GetResultMultiply.result);
            Console.WriteLine(GetResultDivide.result);
            Console.WriteLine(GetResultSubtract.result);
            Console.WriteLine(GetResultAdd.result);

        }
    }
}
