using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity(30);
                    breathingActivity.StartBreathingActivity();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity(30);
                    reflectionActivity.StartReflectionActivity();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity(30);
                    listingActivity.StartListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
