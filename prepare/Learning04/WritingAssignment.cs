public class WritingAssignment : Assignment
{
    private string _Title;

    public WritingAssignment(string StudentName, string Topic, string Title)
    :base(StudentName, Topic)
    {
        _Title = Title;
    }

    public string GetWritingInformation()
    {
        string StudentName = GetStudentName();
        return $"{_Title} by {StudentName}";
    }
}