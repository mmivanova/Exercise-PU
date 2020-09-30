using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbersProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double sum = firstNumber + secondNumber;
            Console.WriteLine("The sum of your numbers is: " + sum);
        }
    }
}
