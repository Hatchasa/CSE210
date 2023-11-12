using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string user_name = Console.ReadLine();
            return user_name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string response = Console.ReadLine();
            int user_number = int.Parse(response);
            return user_number;
        }

        static int SquareNumber(int number)
        {
            int square_number = number * number;
            return square_number;
        }

        static void DisplayResult(string user_name, int square_number)
        {
            DisplayWelcome();
            Console.WriteLine($"Hello {user_name}, your favorite number squared is {square_number}");
        }

        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }

}