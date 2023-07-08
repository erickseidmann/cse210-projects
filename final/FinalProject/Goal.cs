namespace DiaryApp
{
    class Goal
    {
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }

        public Goal(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public void MarkCompleted()
        {
            IsCompleted = true;
        }
    }
}
