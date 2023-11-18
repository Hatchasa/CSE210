using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobtitle = "Software Engineer";
        job1._startyear = 2002;
        job1._endyear = 2020;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobtitle = "Computer Engineer";
        job2._startyear = 1999;
        job2._endyear = 2007;


        Resume myResume = new Resume();
        myResume._name = "Asa Hatch";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();
      
    }
}

