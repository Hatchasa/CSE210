using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("Guess the Magic Number!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        Console.Write("What is your guess? ");
        string answer2 = Console.ReadLine();
        int guess = int.Parse(answer2);

        while (guess != number)
        {
        if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Higher");
        }

        Console.Write("What is your next guess?");
        guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
    }
}