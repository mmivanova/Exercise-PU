using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingTwoNumbersProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter you first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter you second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("After swapping the given numbers, they look like this: " + Environment.NewLine +
                "First number: " + firstNumber + Environment.NewLine +
                "Second number: " + secondNumber);
        }
    }
}
