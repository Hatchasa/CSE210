using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What was your grade percentage? (1-100)");
        string stringgp = Console.ReadLine();
        int gp = int.Parse(stringgp);

        string letter = "";
        
        if (gp >= 90)
        {
            letter = "A";
        }
        else if (gp >= 80)
        {
            letter = "B";
        }
        else if (gp >= 70)
        {
            letter = "C";
        }
        else if (gp >= 60)
        {
            letter = "D";
        }
        else
        {
           letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (gp >= 70)
        {
            Console.WriteLine("Congrats on passing the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time Champ!");
        }
    }
}