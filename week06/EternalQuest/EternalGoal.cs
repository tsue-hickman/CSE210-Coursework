using System;

// Eternal Goal, never completes, just keep doing it
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // empty
    }

    public override void RecordEvent()
    {
        // does not need complettion, so just needs to add points
    }

    public override bool IsComplete()
    {
        return false; // because it is never complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{goalName},{goalDescription},{points}";
    }
}