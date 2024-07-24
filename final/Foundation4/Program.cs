using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Console.WriteLine("\nSummary of activities\n");
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 30));
 

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
