using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator program!");


            bool calculateAgain = true;
            int result;

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
                            result = firstNumber + secondNumber;
                            Console.WriteLine("The result is: {0}", result);
                            break;
                        case '2':
                            result = firstNumber - secondNumber;
                            Console.WriteLine("The result is: {0}", result);
                            break;
                        case '3':
                            result = firstNumber * secondNumber;
                            Console.WriteLine("The result is: {0}", result);
                            break;
                        case '4':
                            result = firstNumber / secondNumber;
                            Console.WriteLine("The result is: {0}", result);
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
