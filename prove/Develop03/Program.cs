using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var reference = new ScriptureReference("Proverbs", 3, 5, 6);
            var scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
            var scripture = new Scripture(reference, scriptureText);

            while (true)
            {
                Console.Clear();
                scripture.Display();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words are hidden. Well done!");
                    break;
                }

                Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
                var input = Console.ReadLine();
                if (input?.ToLower() == "quit") break;

                scripture.HideRandomWords(3);
            }
        }
    }
}
