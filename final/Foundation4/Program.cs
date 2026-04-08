using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("Running", "4/7/26", 75, 5);
        activities.Add(running);
        Cycling cycling = new Cycling("Cycling", "5/2/26", 60, 6);
        activities.Add(cycling);
        Swimming swimming = new Swimming("Swimming", "3/4/26", 30, 10);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}