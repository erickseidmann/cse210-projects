using System;

// Base class for different types of goals
public abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime DateAdded { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsCompleted = false;
        DateAdded = DateTime.Now;
    }

    public abstract void Complete();
}

// Class for simple goals
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
        }
    }

    public override string ToString()
    {
        return $"{Name} - Value: {Value} - Completed: {(IsCompleted ? "Yes" : "No")} - Date Added: {DateAdded}";
    }
}

// Class for checklist goals
public class ChecklistGoal : Goal
{
    public int TargetTimes { get; set; }
    public int TimesCompleted { get; set; }

    public ChecklistGoal(string name, int value, int targetTimes) : base(name, value)
    {
        TargetTimes = targetTimes;
        TimesCompleted = 0;
    }

    public override void Complete()
    {
        if (!IsCompleted)
        {
            TimesCompleted++;
            if (TimesCompleted >= TargetTimes)
            {
                IsCompleted = true;
            }
        }
    }

    public override string ToString()
    {
        return $"{Name} - Value: {Value} - Completed: {(IsCompleted ? "Yes" : "No")} - Times Completed: {TimesCompleted}/{TargetTimes} - Date Added: {DateAdded}";
    }
}
