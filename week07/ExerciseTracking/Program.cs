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

        // Properties for encapsulation
        protected string Date { get { return dateActivity; } }
        protected int Minutes { get { return minutes; } }

        public virtual double GetDistance()
        {
            return 0.0; // overridden in child classes
        }

        public virtual double GetSpeed()
        {
            return 0.0; // overridden in child classes
        }

        public virtual double GetPace()
        {
            return 0.0; // overridden in child classes
        }

        public virtual string GetSummary()
        {
            return $"{Date} Activity ({Minutes} min)";
        }
    }

    // Running class w inheritance
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
            return (distance / Minutes) * 60; // speed in mph
        }

        public override double GetPace()
        {
            return distance != 0 ? Minutes / distance : 0; // min per mile
        }

        public override string GetSummary()
        {
            return $"{Date} Running ({Minutes} min)- Distance {distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }

    // Cycling class inheriting from Activity
    class Cycling : Activity
    {
        private double speed; // in mph

        public Cycling(string date, int minutes, double spd) : base(date, minutes)
        {
            speed = spd;
        }

        public override double GetDistance()
        {
            return (speed * Minutes) / 60; // distance = speed * time
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
            return $"{Date} Cycling ({Minutes} min)- Distance {GetDistance():F1} miles, Speed {speed:F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }

    // Swimming class w inheritance
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
            return (GetDistance() / Minutes) * 60; // mph
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            return distance != 0 ? Minutes / distance : 0; // fixed: check zero
        }

        public override string GetSummary()
        {
            return $"{Date} Swimming ({Minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
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
                Console.WriteLine(activity.GetSummary()); // shows polymorphism
            }
        }
    }
}