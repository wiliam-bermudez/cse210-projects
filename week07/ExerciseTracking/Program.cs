using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
       var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8), // 4.8 km
            new Cycling(new DateTime(2022, 11, 3), 45, 20.0), // 20 kph
            new Swimming(new DateTime(2022, 11, 3), 60, 40) // 40 laps
        };

        foreach (Activity acti in activities)
        {
            Console.WriteLine(acti.GetSummary());
        }
    }
}