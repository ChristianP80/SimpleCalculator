using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            PrintMenu();
            while (true)
            {
                UserChoice(calculator);
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("*******MENU********");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add two numbers:");
            Console.WriteLine("2. Multiply two numbers");
            Console.WriteLine("3. Sum the numbers between two numbers:");
            Console.WriteLine("4. Add number to memory:");
            Console.WriteLine("5. Clear memory:");
            Console.WriteLine("6. Print calculator contents:");
            Console.WriteLine("7. Quit:");
            Console.WriteLine("*******************\n");
        }

        private static void UserChoice(Calculator calculator)
        {
            Console.WriteLine("What do you want to do?");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter two numbers to add!");
                    calculator.FirstNumber = double.Parse(Console.ReadLine());
                    calculator.SecondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("The sum is: " + calculator.SumNumbers());
                    PrintMenu();
                    break;
                case "2":
                    Console.WriteLine("Enter two numbers to multiply!");
                    calculator.FirstNumber = double.Parse(Console.ReadLine());
                    calculator.SecondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("The product of the numbers is: " + calculator.MultiplyNumbers());
                    PrintMenu();
                    break;
                case "3":
                    Console.WriteLine("Enter two numbers!");
                    calculator.FirstNumber = double.Parse(Console.ReadLine());
                    calculator.SecondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Sum in between is: " + calculator.SumInBetween());
                    PrintMenu();
                    break;
                case "4":
                    Console.WriteLine("Enter a number to save to memory!");
                    calculator.NumberInMemory = double.Parse(Console.ReadLine());
                    Console.WriteLine("Number added to memory!");
                    PrintMenu();
                    break;
                case "5":
                    calculator = new Calculator();
                    Console.WriteLine("Memory cleared!");
                    PrintMenu();
                    break;
                case "6":
                    Console.WriteLine("Number in memory is: \n " + calculator);
                    PrintMenu();
                    break;
                case "7":
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }
    }
}
