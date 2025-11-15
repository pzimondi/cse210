using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures (creative enhancement)
        List<Scripture> scriptureLibrary = new List<Scripture>()
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            )
        };

        // Select a scripture at random
        Random rng = new Random();
        Scripture scripture = scriptureLibrary[rng.Next(scriptureLibrary.Count)];

        const int wordsToHideEachStep = 3;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press ENTER to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }

            scripture.HideRandomWords(wordsToHideEachStep);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Well done!");
                Console.WriteLine("Press ENTER to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}
