using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithTwoNumbers
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
            double substraction = firstNumber - secondNumber;
            double division = firstNumber / secondNumber;
            double multiplication = firstNumber * secondNumber;
            double divisionWithRemainder = firstNumber % secondNumber;
           
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {substraction}");
            Console.WriteLine($"{firstNumber} x {secondNumber} = {multiplication}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {Math.Round(division)}");
            Console.WriteLine($"{firstNumber} mod {secondNumber} = {divisionWithRemainder}");
        }
    }
}
