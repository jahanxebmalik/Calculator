using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the computer program!");
            Console.Write("Enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose one number option: ");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("1. Division (/)");
        }
    }
}
