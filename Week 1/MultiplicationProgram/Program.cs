using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number to multiply: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number to multiply: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third number to multiply: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double result = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"{firstNumber} x {secondNumber} x {thirdNumber} = {result}");
        }
    }
}
