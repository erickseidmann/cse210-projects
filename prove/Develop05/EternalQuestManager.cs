using System;
using System.Collections.Generic;
using System.IO;

// Class to manage goals and display the user's score
public class EternalQuestManager
{
    private List<Goal> goals;
    private int score;

    public EternalQuestManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void CompleteGoal(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            if (!goal.IsCompleted)
            {
                goal.Complete();
                score += goal.Value;
                Console.WriteLine($"Points earned: {goal.Value}");
            }
            else
            {
                Console.WriteLine($"Goal already completed: {goal.Name}");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveData(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Write the goals data
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value},{goal.IsCompleted},{goal.DateAdded}");
            }

            // Write the score
            writer.WriteLine(score);
        }
    }

    public void LoadData(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                goals.Clear();

                // Read the goals data
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length >= 5)
                    {
                        string type = data[0];
                        string name = data[1];
                        int value = int.Parse(data[2]);
                        bool isCompleted = bool.Parse(data[3]);
                        DateTime dateAdded = DateTime.Parse(data[4]);

                        Goal goal;
                        if (type == "SimpleGoal")
                        {
                            goal = new SimpleGoal(name, value);
                        }
                        else if (type == "ChecklistGoal")
                        {
                            goal = new ChecklistGoal(name, value, 0);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid goal type: {type}");
                            continue;
                        }

                        goal.IsCompleted = isCompleted;
                        goal.DateAdded = dateAdded;
                        goals.Add(goal);
                    }
                }

                // Read the score
                int.TryParse(reader.ReadLine(), out score);
            }
        }
        else
        {
            Console.WriteLine("No previous data found. Starting with empty goals and score.");
        }
    }
}
