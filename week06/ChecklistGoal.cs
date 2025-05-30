// Checklist goals, this has to be done multiple times thorugh
public class ChecklistGoal : Goal
{
    private int completedTimes; // this is how many times completed the goal 
    private int targetTimes; // how many times the goal needs to be completed

    private int bonusPoints; // extra points for completing the goal



    public ChecklistGoal(string name, string description, int points, int targetTimes, int bonusPoints) : base(name, description, points)
    {

    }
}