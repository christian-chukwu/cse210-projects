using System;

class Program
{
    static void Main(string[] args)
    {

        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running("15 Oct 2025", 30, 3.0),
            new Cycling("15 Oct 2025", 30, 9.7),
            new Swimming("15 Oct 2025", 30, 20)
        };

        // Loop through and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}