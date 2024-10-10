using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        var rand = new Random();
        var unhiddenWords = Words.Where(word => !word.IsHidden).ToList();
        
        for (int i = 0; i < count && unhiddenWords.Any(); i++)
        {
            var word = unhiddenWords[rand.Next(unhiddenWords.Count)];
            word.Hide();
            unhiddenWords.Remove(word);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}
