using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public override void Run()
    {
        StartMessage("Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Countdown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            Countdown(4);
            Console.WriteLine();
        }

        EndMessage("Breathing Activity");
    }
}

