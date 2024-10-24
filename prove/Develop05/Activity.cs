public class Activity
{
    protected int _duration;

    public Activity(int duration)
    {
        _duration = duration;
    }

    public void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}: {description}");
        Console.WriteLine("Prepare to begin...");
        DisplaySpinner(3);  
    }

    public void EndActivity(string activityName)
    {
        Console.WriteLine($"Well done! You have completed the {activityName} activity.");
        Console.WriteLine($"Total duration: {_duration} seconds");
        DisplaySpinner(3); 
    }

    protected void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }
}