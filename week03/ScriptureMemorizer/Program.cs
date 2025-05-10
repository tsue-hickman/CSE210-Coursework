using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string verseText = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life";
        Scripture scripture = new Scripture(reference, verseText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine()?.ToLower();

            if (input == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }

            Random random = new Random();
            int wordsToHide = random.Next(2, 4);
            scripture.HideRandomWords(wordsToHide);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Program ended.");
    }
}