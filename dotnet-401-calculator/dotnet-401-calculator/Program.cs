using System;

namespace dotnet_401_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] variables = new double[2];
            bool confirm = true;
            Intro();

            do
            {
                VariableSelector(variables);
                confirm = ConfirmVar(variables);

            } while (confirm);
            int operation = OperandSelector();
            Console.WriteLine($"You Picked {operation}");
            Calculations(operation, variables);

            Console.ReadLine();
        }

        //***** Menu Interactions
        private static void Intro()
        {
            Console.WriteLine("Welcome to the awesomest Calculator because math");
            Console.Write("\n\n");
            Console.Write("Press enter to begin mathing...");
            Console.ReadLine();
        }
        private static double[] VariableSelector(double[] variables)
        {
            Console.Clear();
            Console.Write("Type in your first number: ");
            variables[0] = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Now give a second number: ");
            variables[1] = Int32.Parse(Console.ReadLine());
            return variables;
        }
        private static int OperandSelector()
        {
            Console.Clear();
            Console.WriteLine("Available Operations:");
            Console.WriteLine("");
            Console.WriteLine("1) addition");
            Console.WriteLine("2) subtraction");
            Console.WriteLine("3) multiplication");
            Console.WriteLine("4) division");
            Console.Write("\n\n");
            Console.Write("Please select a option... ");
            return Int32.Parse(Console.ReadLine());

        }
        private static void Calculations(int operation, double[] variables)
        {
            double result;
            switch(operation)
            {
                case 1:
                    result = Addition(variables[0], variables[1]);
                    Console.WriteLine($"After adding them together, we got {result}");
                    break;
                case 2:
                    result = Subtraction(variables[0], variables[1]);
                    Console.WriteLine($"After subtracting them from another, we got {result}");
                    break;
                case 3:
                    result = Multiplication(variables[0], variables[1]);
                    Console.WriteLine($"After multiplying them together, we got {result}");
                    break;
                case 4:
                    result = Division(variables[0], variables[1]);
                    Console.WriteLine($"After dividing them from another, we got {result}");
                    break;
            }
        }
        //***** User Confirmation to either keep or re-run the variable selection
        private static bool ConfirmVar(double[] variables)
        {
            Console.Clear();
            Console.WriteLine($"you wrote {variables[0]} and {variables[1]} for your variables");
            Console.Write("\n\n");
            Console.Write("Do you want to keep these variables? type y/n: ");
            string input = Console.ReadLine();
            return input == "n" ? true : false;
        }

        //***** Math operations
        private static double Addition(double a, double b)
        {
            return a + b;
        }
        private static double Subtraction(double a, double b)
        {
            return a - b;
        }
        private static double Multiplication(double a, double b)
        {
            return a * b;
        }
        private static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
