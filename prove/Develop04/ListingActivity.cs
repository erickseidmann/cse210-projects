using System;
using System.Collections.Generic;

namespace BreathingApp
{
    public class ListingActivity : Activity
    {
        private List<string> prompts;

        public ListingActivity(string name, string description) : base(name, description)
        {
            prompts = new List<string>
            {
                "Who are the people you appreciate?",
                "What are your personal strengths?",
                "Who are the people you helped this week?",
                "When did you feel the Holy Spirit this month?",
                "Who are some of your personal heroes?"
            };
        }

        public override void Start()
        {
            Console.WriteLine($"Activity: {name}");
            Console.WriteLine(description);

            Console.Write("Enter duration in seconds: ");
            duration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Get ready...");
            Thread.Sleep(3000);

            Console.WriteLine("Start listing...");

            Random random = new Random();
            int itemCount = 0;

            for (int i = 0; i < duration; i++)
            {
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine(prompt);

                DisplayCountdown(3);

                Console.WriteLine("Start listing items. Press Enter after you write each item. Enter 'done' when you want to finish.");

                string input = Console.ReadLine();
                while (input.ToLower() != "done")
                {
                    itemCount++;
                    input = Console.ReadLine();
                }

                Console.WriteLine($"Number of items listed: {itemCount}");
            }

            Console.WriteLine("Good job! Take a break.");
            DisplayMessage($"Completed {name} for {duration} seconds.", 3);
        }
    }
}
