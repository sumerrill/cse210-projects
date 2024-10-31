using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        ExerciseActivity running = new RunningActivity("03 Nov 2022", 30, 3.0);
        ExerciseActivity cycling = new CyclingActivity("03 Nov 2022", 30, 15.0);
        ExerciseActivity swimming = new SwimmingActivity("03 Nov 2022", 30, 20);

        List<ExerciseActivity> activities = new List<ExerciseActivity> { running, cycling, swimming };

        foreach (ExerciseActivity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
