using System;

namespace dotnet_401_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();

        }
        private static void Intro()
        {
            Console.WriteLine("Welcome to the awesomest Calculator because math");
            Console.Write("\n\n");
            Console.Write("Press enter to begin mathing...");
            Console.Read();
        }
        private static void CalcMenu()
        {

        }
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
