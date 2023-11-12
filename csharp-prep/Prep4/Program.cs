using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers: (type 0 when done.)");
        List<int> numbers = new List<int>();
        
        int number = 0;
        do
        {
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }
            
        } while (number != 0);

        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The Sum is: {sum}");


        int length = numbers.Count();
        int avg = sum/length;
        Console.WriteLine($"The Average is: {avg}");

        int max = 0;
        foreach (int i in numbers)
        {
            if (i > max)
            {
                max = i;
            }
        }    

        Console.WriteLine($"The Max is: {max}");
    }
}