using System;

namespace dotnet_401_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] variables = new double[2];
            bool confirm = true;
            bool active = true;
            bool rerun = false;

            Intro();
            //This do/while ensures that the user can continue
            //to do math equations if desired
            do
            {
                //This loop allows users to confirm the 
                //variables they've selected
                do
                {
                    VariableSelector(variables);
                    confirm = ConfirmVar(variables);

                } while (confirm);
                //This loop helps catch selection outside of the
                //current scope
                do
                {
                    int operation = OperandSelector();
                    Console.WriteLine($"You Picked {operation}");
                    rerun = Calculations(operation, variables);

                } while (rerun);

                active = AppContinue();
            } while (active);

            GamePlay();
        }

        //***** Menu Interactions live in this block and happen in the order
        //      that the user will experience them
        private static void Intro()
        {
            Console.WriteLine("Welcome to the awesomest Calculator because math");
            Console.Write("\n\n");
            Console.WriteLine("Think about the operation you would like to proceed with when selecting numbers");
            Console.Write("\n");
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
            Console.WriteLine("5) power");
            Console.WriteLine("6) modulo/remainder");
            Console.Write("\n\n");
            Console.Write("Please select a option... ");
            return Int32.Parse(Console.ReadLine());

        }
        private static bool Calculations(int operation, double[] variables)
        {
            double result;
            bool rerun = false;
            switch (operation)
            {
                case 1:
                    result = Addition(variables[0], variables[1]);
                    Console.WriteLine($"Welcome to the summation nation. {result} is your answer.");
                    break;
                case 2:
                    result = Subtraction(variables[0], variables[1]);
                    Console.WriteLine($"Subtract that. {result} is the reasonable response.");
                    break;
                case 3:
                    result = Multiplication(variables[0], variables[1]);
                    Console.WriteLine($"Multiplication situation. {result} is your answer.");
                    break;
                case 4:
                    result = Division(variables[0], variables[1]);
                    Console.WriteLine($"After dividing them from another, we got {result}. No catchy thing here.");
                    break;
                case 5:
                    result = Math.Pow(variables[0], variables[1]);
                    Console.WriteLine($"After summoning the power of greyskull, we exponentially got {result}");
                    break;
                case 6:
                    result = Remainder(variables[0], variables[1]);
                    Console.WriteLine($"I'm here to give you a remainder. {result} is left");
                    break;
                default:
                    Console.WriteLine($"Sorry but {operation} isn't a valid choice");
                    rerun = true;
                    break;
            }
            Console.ReadLine();
            return rerun;
        }
        private static void GamePlay()
        {
            Console.Clear();
            Console.Write("Would you like to play a game? y/n: ");
            string input = Console.ReadLine().ToLower();
            if (input == "y") NumberGuesser();
            else
            {
                Console.Clear();
                Console.WriteLine("Well fine then. Have a good day");
                Console.ReadLine();
            }
        }
        //***** User Confirmation to either keep or re-run specified loops
        private static bool ConfirmVar(double[] variables)
        {
            Console.Clear();
            Console.WriteLine($"you wrote {variables[0]} and {variables[1]} for your variables");
            Console.Write("\n\n");
            Console.Write("Do you want to keep these variables? type y/n: ");
            string input = Console.ReadLine();
            return input == "n" ? true : false;
        }
        private static bool AppContinue()
        {
            Console.Clear();
            Console.Write("Would you like to continue the math? y/n: ");
            string input = Console.ReadLine().ToLower();
            if (input == "y") return true;
            else return false;
        }
        //***** Math operations live here and are in the order of the switch statement
        //      with the exception of the Math.Pow method
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
        private static double Remainder(double a, double b)
        {
            return a % b;
        }
        //***** Game Brain sits here. It uses the Random Class to generate a
        //      number between 1 and 10 and the user has 3 attempts before exiting
        private static void NumberGuesser()
        {
            Console.Clear();
            Random random = new Random();
            int ranNum = random.Next(1, 11);
            int guess = 3;
            bool success = false;
            Console.WriteLine("Welcome to the Number Guesser. Pick a number between 1 and 10. You get three chances!");
            Console.Write("\n\n");
            while(guess > 0)
            {
                int input = Int32.Parse(Console.ReadLine());
                if(input != ranNum)
                {
                    Console.WriteLine($"No. {input} isn't the number. Go ahead and try again!");
                    Console.Write("\n");
                    guess--;
                    Console.WriteLine($"You have {guess} left");
                    Console.WriteLine($"Try again!");
                } else
                {
                    Console.WriteLine($"Woohoo! You did it! {input} is the {ranNum}!");
                    Console.WriteLine("See you next time!");
                    success = true;
                    guess = 0;
                    Console.ReadLine();
                }
            }
            if (!success)
            {
                Console.Clear();
                Console.WriteLine($"Oh not this time. the number was {ranNum}");
                Console.WriteLine("Bye-bye!");
                Console.ReadLine();
            }
        }
    }
}
