using System;

class Program
{
    static void Main(string[] args)
    {
   string dataFileName = "data.csv";
        EternalQuestManager manager = new EternalQuestManager();
        manager.LoadData(dataFileName);

        int choice;
        do
        {
            choice = DisplayMenu();
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal(manager);
                    break;
                case 2:
                    CompleteGoal(manager);
                    break;
                case 3:
                    manager.DisplayGoals();
                    break;
                case 4:
                    manager.DisplayScore();
                    break;
                case 5:
                    manager.SaveData(dataFileName);
                    Console.WriteLine("Data saved successfully.");
                    break;
                case 6:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
        while (choice != 6);
    }

    static int DisplayMenu()
    {
        Console.WriteLine("Eternal Quest");
        Console.WriteLine("1. Add Goal");
        Console.WriteLine("2. Complete Goal");
        Console.WriteLine("3. Display Goals");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Save Data");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice. Please enter a valid integer.");
            Console.Write("Enter your choice: ");
        }

        return choice;
    }

    static void CreateGoal(EternalQuestManager manager)
    {
        Console.WriteLine("Create Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.Write("Enter goal type: ");

        int type;
        while (!int.TryParse(Console.ReadLine(), out type) || (type != 1 && type != 2))
        {
            Console.WriteLine("Invalid type. Please enter 1 or 2.");
            Console.Write("Enter goal type: ");
        }

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal value: ");
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid value. Please enter a valid integer.");
            Console.Write("Enter goal value: ");
        }

        if (type == 1)
        {
            Goal goal = new SimpleGoal(name, value);
            manager.AddGoal(goal);
            Console.WriteLine("Simple goal added successfully.");
        }
        else if (type == 2)
        {
            Console.Write("Enter target times for checklist goal: ");
            int targetTimes;
            while (!int.TryParse(Console.ReadLine(), out targetTimes))
            {
                Console.WriteLine("Invalid target times. Please enter a valid integer.");
                Console.Write("Enter target times for checklist goal: ");
            }

            Goal goal = new ChecklistGoal(name, value, targetTimes);
            manager.AddGoal(goal);
            Console.WriteLine("Checklist goal added successfully.");
        }
    }

    static void CompleteGoal(EternalQuestManager manager)
    {
        Console.WriteLine("Complete Goal");
        manager.DisplayGoals();

        Console.Write("Enter goal index: ");
        int index;
        while (!int.TryParse(Console.ReadLine(), out index))
        {
            Console.WriteLine("Invalid index. Please enter a valid integer.");
            Console.Write("Enter goal index: ");
        }

        manager.CompleteGoal(index - 1);
    }
}