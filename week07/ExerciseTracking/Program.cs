using System;

namespace ExerciseTracking
{
    // Base class for the activitiees
    class Activity
    {
        private string dateActivity; // date of the activity
        private int minutes;

        public Activity(string date, int min)
        {
            dateActivity = date;
            minutes = min;
        }

        public virtual double GetDistance()
        {
            return 0.0; // will be overriden in child classes
        }

        public virtual double GetSpeed()
        {
            return 0.0; // will be overriden in child classes
        }

        public virtual double GetPace()
        {
            return 0.0; // will be overriden in child classes
        }

        public virtual string GetSummary()
        {
            return $"{dateActivity} Activity ({minutes} min)";
        }
    }

    // Running class w inhertance
    class Running : Activity
    {
        private double distance; // distance in miles

        public Running(string date, int minutes, double dist) : base(date, minutes)
        {
            distance = dist;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return (distance / minutes) * 60; // speed in mph
        }

        public override double GetPace()
        {
            return distance != 0 ? minutes / distance : 0; // min per mile, check for zero
        }

        public override string GetSummary()
        {
            return $"{dateActivity} Running ({minutes} min)- Distance {distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Running run = new Running("03 Nov 2022", 30, 3.0);
            Console.WriteLine(run.GetSummary());
        }
    }
}