using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }

        public int Add()
        {
            return Operand1 + Operand2;
        }
        public int Subtract()
        {
            return Operand1 - Operand2;
        }
        public int Multiply()
        {
            return Operand1 * Operand2;
        }
        public int Devide()
        {
            return Operand1 / Operand2;
        }
    }
}
