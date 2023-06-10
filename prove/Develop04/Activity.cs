using System;
using System.Threading;

namespace BreathingApp
{
    public abstract class Activity
    {
        protected string name;
        protected string description;
        protected int duration;

        public Activity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public abstract void Start();

        protected void DisplayCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        protected void DisplayMessage(string message, int seconds)
        {
            Console.WriteLine(message);
            Thread.Sleep(seconds * 1000);
        }
    }
}