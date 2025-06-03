using System;
using System.Collections.Generic;

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
            return distance != 0 ? minutes / distance : 0; // min per mile
        }

        public override string GetSummary()
        {
            return $"{dateActivity} Running ({minutes} min)- Distance {distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }

    // Cycling class inherting from Activity
    class Cycling : Activity
    {
        private double speed; // in mph
        public Cycling(string date, int minutes, double spd) : base(date, minutes)
        {
            speed = spd;
        }

        public override double GetDistance()
        {
            return (speed * minutes) / 60; // distance = speed * time
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return speed != 0 ? 60 / speed : 0; // min per mile
        }

        public override string GetSummary()
        {
            return $"{dateActivity} Cycling ({minutes} min)- Distance {GetDistance():F1} miles, Speed {speed:F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }

    // Swimming class w inhertance
    class Swimming : Activity
    {
        private int laps;

        public Swimming(string date, int minutes, int lap) : base(date, minutes)
        {
            laps = lap;
        }

        public override double GetDistance()
        {
            return (laps * 50.0 / 1000) * 0.62; // 50m per lap, convert to miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / minutes) * 60; // mph
        }

        public override double GetPace()
        {
            return minutes / GetDistance(); // wrong: no zero check
        }

        public override string GetSummary()
        {
            return $"{dateActivity} Swimming ({minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running("03 Nov 2022", 30, 3.0),
                new Cycling("03 Nov 2022", 45, 12.0),
                new Swimming("03 Nov 2022", 20, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary()); // shows polymorfism
            }
        }
    }
}