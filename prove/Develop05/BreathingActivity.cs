public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public void StartBreathingActivity()
    {
        StartActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.");
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            DisplaySpinner(3);  
            Console.WriteLine("Breathe out...");
            DisplaySpinner(3);  
            elapsedTime += 6;
        }
        EndActivity("Breathing");
    }
}
