using System;
namespace DiaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.LoadPreviousEntries("diario.csv");
            diary.Start();
        }
    }
}