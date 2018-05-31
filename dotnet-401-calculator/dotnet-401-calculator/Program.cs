using System;

namespace dotnet_401_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] variables = new double[2];
            Intro();
            VariableSelector(variables);
            Console.Write($"you wrote {variables[0]} and {variables[1]} for your variables");
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

        //***** Math operations
        private static int Addition(int a, int b)
        {
            return a + b;
        }
        private static int Subtraction(int a, int b)
        {
            return a - b;
        }
        private static int Multiplication(int a, int b)
        {
            return a * b;
        }
        private static int Division(int a, int b)
        {
            return a / b;
        }
    }
}
