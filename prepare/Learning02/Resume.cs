using System;

// Unsure why 'Resume' is underlined red. The program works fine. Checked help code to compare why I have this issue.
// Create a class called 'Resume'
public class Resume
{
    // Attributes (_name and _jobs on this resume)
    public string _name;
        //This is a list of jobs attached to a specific person 
    public List<Job> _jobs = new List<Job>();

    // Behaviors (display method to display the name and jobs of a certain individual)
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // foreach loop to display each job in the list of jobs
        foreach (Job job in _jobs)
        {
            job.Display(); // Corrected
        }
    }
}
