using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator program!");


            bool calculateAgain = true;

            try
            {

                while (calculateAgain)
                {
                    char operation;

                    Console.Write("\nEnter your first number: ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your second number: ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose one number option: ");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.WriteLine("3. Multiplication (*)");
                    Console.WriteLine("4. Division (/)");
                    Console.WriteLine("Enter q to quit");

                    operation = Convert.ToChar(Console.ReadLine());

                    switch (operation)
                    {
                        case '1':
                            int addition = firstNumber + secondNumber;
                            Console.WriteLine("The result is: {0}", addition);
                            break;
                        case '2':
                            int minus = firstNumber - secondNumber;
                            Console.WriteLine("The result is: {0}", minus);
                            break;
                        case '3':
                            int multiply = firstNumber * secondNumber;
                            Console.WriteLine("The result is: {0}", multiply);
                            break;
                        case '4':
                            int divide = firstNumber / secondNumber;
                            Console.WriteLine("The result is: {0}", divide);
                            break;
                        case 'q':
                            calculateAgain = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect value!");
                            break;
                    }
                }
            }
            catch
            {
                Console.Write("Incorrect value!");
            }
        }
    }
}
