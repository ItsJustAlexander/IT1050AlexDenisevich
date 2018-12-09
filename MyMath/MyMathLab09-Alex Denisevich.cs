using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLab_Alex_Denisevich
{
    class MyMath
    {
        public double result;
        public double operand1;
        public double operand2;

        public void Multiply(double operand1, double operand2)
        {
            this.result = operand1 * operand2;
            return;
        }
        public void Divide(double operand1, double operand2)
        {
            this.result = operand1 / operand2;
            return;
        }
        public void Subtract(double operand1, double operand2)
        {
            this.result = operand1 - operand2;
            return;
        }
        public void Add(double operand1, double operand2)
        {
            this.result = operand1 + operand2;
            return;
        }
        

        public void GetResult()
        {
        }

    }
}
