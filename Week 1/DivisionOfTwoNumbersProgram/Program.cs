using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionOfTwoNumbersProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            if (secondNumber != 0)
            {
                double result = firstNumber / secondNumber;
                Console.WriteLine("The result from the division is: " + result);
            }
            else
            {
                Console.WriteLine("You cannot divide by 0!");
            }
        }
    }
}
