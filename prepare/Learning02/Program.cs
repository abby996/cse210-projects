using System;
using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        List<Job> work = new List<Job>();
        work.Add(job1);
        work.Add(job2);
         
         foreach (Job j in work )
         {
            Console.WriteLine(j._jobTitle);
         }

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}