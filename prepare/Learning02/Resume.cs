using System;

public class Resume
{
    public List<Job> _jobs = new List<Job>();
    public string _name;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}