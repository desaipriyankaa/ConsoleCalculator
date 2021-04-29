using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();
            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex)
            {
                WriteLine($"operation can not be null {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine($"Can not find enetered operation.. please enter correct operation {ex}");
            }
            catch (Exception ex)
            {
                WriteLine($"Sorry something went wrong...{ex}");

            }
            
            
            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
