using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        // Create a new job and assign strings to each attribute
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2019";
        job1._endYear = "2022";

        //job1.Display();

        // Create a second job and assign strings to each attribute
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = "2020";
        job2._endYear = "2024";

        //job2.Display();

        // Create a new resume and give it a name
        Resume newResume = new Resume();
        newResume._name = "First Last";

        // Add jobs to that resume
        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        // Display the resume (name and jobs)
        newResume.Display();
    }
}