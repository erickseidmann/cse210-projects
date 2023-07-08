using System;

namespace DiaryApp
{
    class Entry
    {
        public DateTime Date { get; private set; }
        public string Content { get; private set; }

        public Entry(DateTime date, string content)
        {
            Date = date;
            Content = content;
        }

        public string ToCsvFormat()
        {
            return $"{Date},{Content}";
        }
    }
}
