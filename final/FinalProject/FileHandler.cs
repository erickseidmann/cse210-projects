using System.IO;

namespace DiaryApp
{
    class FileHandler
    {
        public void SaveToFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }
    }
}
