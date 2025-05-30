using System;
using System.Collections.Generic;

// will manage the goals and stuff on menu
public class GoalManager
{
    private List<Goal> goalsList; // list of total goals
    private int playerScore;  // score of the current player

    public GoalManager()
    {
        goalsList = new List<Goal>(); // empty list to start
        playerScore = 0;     // score starts at 0
    }

    public void Start()
    {
        // main menu loop goes here
    }

    public void DisplayPlayerInfo()
    {
        // shows scores and stuff
    }

    public void ListGoalNames()
    {
        //shows the goal names in a list
    }

    public void ListGoalDetails()
    {
        // show the goal details 
    }

    public void CreateGoal()
    {
        // creates new goals
    }

    public void RecordEvent()
    {
        // allows for progress to be recorded
    }

    public void SaveGoals()
    {
        // saves the goals to a file
    }

    public void LoadGoals()
    {
        // loads the goals from a file
    }
}