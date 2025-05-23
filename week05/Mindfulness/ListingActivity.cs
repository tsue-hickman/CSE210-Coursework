using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Run()
    {
        StartMessage("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Console.WriteLine("You may begin in:");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                items.Add(Console.ReadLine());
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        EndMessage("Listing Activity");
    }
}
