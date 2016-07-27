using System;


namespace MyCalculator
{
    public class Class1
    {
        public static void Main()
        {
            Calculator caclulator = new Calculator();
            caclulator.Operand1 = 100;
            caclulator.Operand2 = 200;
            Console.WriteLine(caclulator.Add());
            Console.WriteLine(caclulator.Subtract());
            Console.WriteLine(caclulator.Multiply());
            Console.WriteLine(caclulator.Devide());
        }
    }
}
