public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public void StartListingActivity()
    {
        StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        DisplaySpinner(3);

        int elapsedTime = 0;
        int itemCount = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
            elapsedTime += 5;
        }
        Console.WriteLine($"You listed {itemCount} items.");
        EndActivity("Listing");
    }
}
