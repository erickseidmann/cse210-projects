using System;
using System.Collections.Generic;

namespace BreathingApp
{
    public class ReflectionActivity : Activity
    {
        private List<string> prompts;
        private List<string> questions;

        public ReflectionActivity(string name, string description) : base(name, description)
        {
            prompts = new List<string>
            {
                "Think of a time when you stood up for someone.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you done something like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different from other times when you didn't have as much success?",
                "What is your favorite thing about this experience?",
                "What can you learn from this experience that applies to other situations?",
                "What have you learned about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
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
            
                Console.WriteLine("Start reflecting...");
            
                Random random = new Random();
            
                for (int i = 0; i < duration; i++)
                {
                    string prompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine(prompt);
            
                    DisplayCountdown(3);
            
                    string question = questions[random.Next(questions.Count)];
                    Console.WriteLine(question);
                    DisplayCountdown(5);
                }
            
                Console.WriteLine("Good job! Take a break.");
                DisplayMessage($"Completed {name} for {duration} seconds.", 3);
            }
    }
}
