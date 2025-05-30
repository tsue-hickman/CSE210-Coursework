// Checklist goals, this has to be done multiple times thorugh  ~ tracks progress across mulitple completions, calculates when fully done, shows extra bonus info
public class ChecklistGoal : Goal
{
    private int completedTimes; // this is how many times completed the goal 
    private int targetTimes; // how many times the goal needs to be completed

    private int bonusPoints; // extra points for completing the goal



    public ChecklistGoal(string name, string description, int points, int targetTimes, int bonusPoints) : base(name, description, points)
    {
        completedTimes = 0; //starts at 0
        this.targetTimes = targetTimes;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        // will add to  the completedTimes later
    }

    public override bool IsComplete()
    {
        return completedTimes >= targetTimes;
    }

    //need to show the progress and the bonuses
    public override string GetDetailsString()
    {
        return $"{goalName}: {goalDescription} ({bonusPoints} points, Done {completedTimes}/{targetTimes}, Bonus: {bonusPoints})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{goalName}, {goalDescription}, {points}, {completedTimes}, {targetTimes}, {bonusPoints}";
    }
}