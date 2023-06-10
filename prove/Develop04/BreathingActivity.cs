using System;

namespace BreathingApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description) : base(name, description)
        {
        }

        public override void Start()
        {
            Console.WriteLine($"Activity: {name}");
            Console.WriteLine(description);

            Console.Write("Enter duration in seconds: ");
            duration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Get ready...");
            Thread.Sleep(3000);

            Console.WriteLine("Start breathing...");

            for (int i = 0; i < duration; i++)
            {
                string message = (i % 2 == 0) ? "Inhale..." : "Exhale...";
                Console.WriteLine(message);
                DisplayCountdown(3);
            }

            Console.WriteLine("Good job! Take a break.");
            DisplayMessage($"Completed {name} for {duration} seconds.", 3);
        }
    }
}
