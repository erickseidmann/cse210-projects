public class MathAssigment : Assignment
{
    private string _TextBookSection;
    private string _Problems;

    public MathAssigment (string StudentName, string Topic, string TextBookSection, string problems)
    : base(StudentName, Topic)
    {
        _TextBookSection = TextBookSection;
        _Problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_TextBookSection} Problems:{_Problems}";
    }
}