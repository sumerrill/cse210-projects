public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public void StartReflectionActivity()
    {
        StartActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        DisplaySpinner(3);

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            DisplaySpinner(5);
            elapsedTime += 5;
        }
        EndActivity("Reflection");
    }
}