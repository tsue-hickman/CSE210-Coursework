using System;

// This is the main Goal class, its abstract b/c all goals share stuff
public abstract class Goal
{
    protected string goalName; // Name of the goal
    protected string goalDescription; // Description of the goal
    protected int points; // Points for the goal

    public Goal(string name, string description, int pointsValue)
    {
        goalName = name;
        goalDescription = description;
        points = pointsValue;
    }
}



//gotta define these in child classes
public abstract void RecordEvent();
    public abstract bool IsComplete();



