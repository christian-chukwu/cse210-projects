// Exceeding Requirments:
// Program can randomly select from a library of scriptures, not just one fixed verse.
// User can press Enter to hide words OR type 'quit' to stop anytime.
// Program ensures only visible words get hidden (avoiding wasted random choices)

using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.\n");
        Console.ReadLine();

        // Library of scriptures
        List<Scripture> scriptures = new List<Scripture> {
    new Scripture(new Reference("Isaiah", 41, 10),
    "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."),

    new Scripture(new Reference("Joshua", 1, 9),
    "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."),

    new Scripture(new Reference("2 Timothy", 1, 7),
    "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind."),

    new Scripture(new Reference("Romans", 12, 2),
    "And be not conformed to this world: but be ye transformed by the renewing of your mind, that ye may prove what is that good, and acceptable, and perfect, will of God."),

    new Scripture(new Reference("Psalm", 119, 11),
    "Thy word have I hid in mine heart, that I might not sin against thee.")
};

        // Pick a random scripture
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words at a time

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }
        }
    }
}

