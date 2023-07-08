using System;

namespace DiaryApp
{
    class Exercise
    {
        public string Name { get; private set; }
        public bool Completed { get; private set; }

        
        public Exercise(string name)
        {
            Name = name;
            Completed = false;
        }

        public void MarkCompleted()
        {
            Completed = true;
        }
    }
}
