using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new BreathingActivity(60),
            new ListingActivity(90),
            new ReflectingActivity(120)
        };

        foreach (var activity in activities)
        {
            activity.Run();
        }
    }
}