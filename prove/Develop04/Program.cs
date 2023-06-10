using System;

namespace BreathingApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("========== Menu ==========");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                Activity activity = null;

                switch (choice)
                {
                    case 1:
                        activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by going through your breath slowly. Clear your mind and focus on your breathing.");
                        break;
                    case 2:
                        activity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on moments in your life when you have shown strength and resilience. It will help you recognize the power you have and how you can use it in other aspects of your life.");
                        break;
                    case 3:
                        activity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a specific area.");
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (activity != null)
                {
                    activity.Start();
                }

                Console.WriteLine();
            }
        }
    }
}
