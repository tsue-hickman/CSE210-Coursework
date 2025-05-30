using System;

//Simple Goal, so it is a one and done kind of goal
public class SimpleGoal : Goal
{
    private bool isDone = false; // should track if the goal is completed

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        isDone = false; // need to make sure it isn't done yet
    }
}