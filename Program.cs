using System;
using System.Runtime.InteropServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumbers(64, 32);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        private static int AddNumbers(int numberOne, int numberTwo)
        {
            int CalculationResult;
            CalculationResult = numberOne + numberTwo;
            return CalculationResult;
        }
    }
}
