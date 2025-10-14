using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("14 Oct 2025", 30, 3.0));
        activities.Add(new Cycling("14 Oct 2025", 45, 15.0));
        activities.Add(new Swimming("14 Oct 2025", 60, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(); // Add a blank line for better readability
        }
    }
}