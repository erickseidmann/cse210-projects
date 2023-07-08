using System;
using System.Collections.Generic;

namespace DiaryApp
{
    class Scriptures
    {
        private List<string> motivationalScriptures;

        public Scriptures()
        {
            motivationalScriptures = new List<string>()
            {
                "Scripture 1",
                "Scripture 2",
                "Scripture 3",
                "Scripture 4",
                "Scripture 5"
            };
        }

        public string GetRandomMotivationalScripture()
        {
            Random random = new Random();
            int index = random.Next(motivationalScriptures.Count);
            return motivationalScriptures[index];
        }
    }
}
