using System;

class Program
{
    // Creative Addition:
    // To exceed requirements, I added a mood-tracking feature. Users can assign a mood (Happy, Sad, Neutral)
    // to each entry when writing it, and a new menu option (5) allows filtering displayed entries by mood.
    // This addresses the barrier of "not knowing what to write" by encouraging emotional reflection and
    // allows users to review entries based on their mood, enhancing engagement with the journal.

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Display entries by mood");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.Write("Enter mood to filter (Happy, Sad, Neutral): ");
                    string mood = Console.ReadLine();
                    journal.DisplayEntriesByMood(mood);
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}