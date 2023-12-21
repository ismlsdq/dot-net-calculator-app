using System;
using CalculatorApp.Operations;

namespace CalculatorApp.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Calculator");
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation: (+, -, *, /)");
                char operation = Convert.ToChar(Console.ReadLine());

                Calculator calculator = new Calculator();
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = calculator.Calculate(num1, num2, new Addition());
                        break;
                    case '-':
                        result = calculator.Calculate(num1, num2, new Subtraction());
                        break;
                    case '*':
                        result = calculator.Calculate(num1, num2, new Multiplication());
                        break;
                    case '/':
                        result = calculator.Calculate(num1, num2, new Division());
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}