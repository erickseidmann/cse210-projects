using System;
using System.Collections.Generic;
using System.IO;

namespace DiaryApp
{
    class Diary
    {
        private List<Entry> entries;
        private List<Goal> goals;
        private List<Exercise> exercises;
        private Scriptures scriptures;
        private FileHandler fileHandler;

        public Diary()
        {
            entries = new List<Entry>();
            goals = new List<Goal>();
            exercises = new List<Exercise>();
            scriptures = new Scriptures();
            fileHandler = new FileHandler();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to your diary!");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. View Previous Days");
                Console.WriteLine("2. Start a New Day");
                Console.WriteLine("3. Add a New Exercise");
                Console.WriteLine("4. View Completed Exercises");
                Console.WriteLine("5. View In-Progress Exercises");
                Console.WriteLine("6. Save and Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        ViewPreviousDays();
                        break;
                    case "2":
                        StartNewDay();
                        break;
                    case "3":
                        AddExercise();
                        break;
                    case "4":
                        ViewCompletedExercises();
                        break;
                    case "5":
                        ViewInProgressExercises();
                        break;
                    case "6":
                        SaveChanges();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void ViewPreviousDays()
        {
            if (entries.Count > 0)
            {
                Console.WriteLine("Previous Days:");
                foreach (Entry entry in entries)
                {
                    Console.WriteLine($"{entry.Date.ToShortDateString()}: {entry.Content}");
                }
            }
            else
            {
                Console.WriteLine("No previous days found.");
            }
        }

        private void StartNewDay()
        {
            Console.WriteLine("Starting a New Day...");

            // Check if scriptures were read today
            bool scripturesRead = AskScripturesRead();

            // If scriptures were not read, provide a motivational scripture
            if (!scripturesRead)
            {
                Console.WriteLine("Motivational Scripture: " + scriptures.GetRandomMotivationalScripture());
            }

            // Add entry to diary
            Console.WriteLine("Please write down the good things you saw today:");
            string goodThings = Console.ReadLine();
            AddEntry(goodThings);

            // Mark completed exercise and check for reward
            if (exercises.Count > 0)
            {
                Console.WriteLine("Did you complete your exercise today? (Y/N)");
                string exerciseCompleted = Console.ReadLine();
                if (exerciseCompleted.ToUpper() == "Y")
                {
                    Exercise completedExercise = SelectExercise();
                    completedExercise.MarkCompleted();
                    Console.WriteLine("Congratulations! You can have a chocolate today.");
                }
            }
            else
            {
                Console.WriteLine("No exercises found. Please add a new exercise.");
            }
        }

        private void AddExercise()
        {
            Console.Write("Enter the name of the new exercise: ");
            string exerciseName = Console.ReadLine();
            Exercise exercise = new Exercise(exerciseName);
            exercises.Add(exercise);
            Console.WriteLine($"Exercise '{exerciseName}' added successfully!");
        }

        private void ViewCompletedExercises()
        {
            List<Exercise> completedExercises = GetCompletedExercises();
            if (completedExercises.Count > 0)
            {
                Console.WriteLine("Completed Exercises:");
                foreach (Exercise exercise in completedExercises)
                {
                    Console.WriteLine(exercise.Name);
                }
            }
            else
            {
                Console.WriteLine("No completed exercises found.");
            }
        }

        private void ViewInProgressExercises()
        {
            List<Exercise> inProgressExercises = GetInProgressExercises();
            if (inProgressExercises.Count > 0)
            {
                Console.WriteLine("In-Progress Exercises:");
                foreach (Exercise exercise in inProgressExercises)
                {
                    Console.WriteLine(exercise.Name);
                }
            }
            else
            {
                Console.WriteLine("No in-progress exercises found.");
            }
        }

        private List<Exercise> GetCompletedExercises()
        {
            List<Exercise> completedExercises = new List<Exercise>();
            foreach (Exercise exercise in exercises)
            {
                if (exercise.Completed)
                {
                    completedExercises.Add(exercise);
                }
            }
            return completedExercises;
        }

        private List<Exercise> GetInProgressExercises()
        {
            List<Exercise> inProgressExercises = new List<Exercise>();
            foreach (Exercise exercise in exercises)
            {
                if (!exercise.Completed)
                {
                    inProgressExercises.Add(exercise);
                }
            }
            return inProgressExercises;
        }

        private bool AskScripturesRead()
        {
            Console.WriteLine("Have you read the scriptures today? (Y/N)");
            string scripturesRead = Console.ReadLine();
            if (scripturesRead.ToUpper() == "Y")
            {
                Console.WriteLine("Please write down your favorite part of today's scriptures:");
                string favoritePart = Console.ReadLine();
                AddEntry("Favorite Part of Scriptures: " + favoritePart);
                return true;
            }

            return false;
        }

        private void AddEntry(string content)
        {
            Entry entry = new Entry(DateTime.Now, content);
            entries.Add(entry);
        }

        private Exercise SelectExercise()
        {
            Console.WriteLine("Select an exercise:");
            for (int i = 0; i < exercises.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {exercises[i].Name}");
            }

            int exerciseIndex = -1;
            while (exerciseIndex < 0 || exerciseIndex >= exercises.Count)
            {
                Console.Write("Enter exercise number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out exerciseIndex))
                {
                    exerciseIndex--; // Adjust index to 0-based
                }
            }

            return exercises[exerciseIndex];
        }

        private void SaveChanges()
        {
            string csvContent = "";
            foreach (Entry entry in entries)
            {
                csvContent += entry.ToCsvFormat() + "\n";
            }

            fileHandler.SaveToFile("diario.csv", csvContent);
            Console.WriteLine("Changes saved successfully!");
        }

        public void LoadPreviousEntries(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        DateTime date;
                        if (DateTime.TryParse(parts[0], out date))
                        {
                            string content = parts[1];
                            Entry entry = new Entry(date, content);
                            entries.Add(entry);
                        }
                    }
                }
            }
        }
    }
}
