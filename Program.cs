using System;
namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task -1 Hello World
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            //Task -2 Variables and User Input
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadKey();

            //Task -3 Basic Arithmetic
            Console.WriteLine("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num2 != 0 ? num1 / num2 : 0;
            int remainder = num2 != 0 ? num1 % num2 : 0;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
            Console.ReadKey();

            //Task -4 Control Structure
            Console.WriteLine("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.ReadKey();


            //Task -5 Loops
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //Task -6 Arrays
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum1 = 0;

            foreach (int num in numbers)
            {
                sum1 += num;
            }

            double average = (double)sum1 / numbers.Length;

            Console.WriteLine($"Sum: {sum1}");
            Console.WriteLine($"Average: {average}");
            Console.ReadKey();

            //Task -7 Exception Handling
            int age = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Please enter your age: ");
                string input = Console.ReadLine();

                isValidInput = int.TryParse(input, out age);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
            Console.ReadKey();

            //Task - 8 Methods
                Console.WriteLine("Enter an integer: ");
            int number1 = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(number1);
            Console.WriteLine($"Factorial of {number1}: {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
                Console.ReadKey();
            }
        }
    }
}
