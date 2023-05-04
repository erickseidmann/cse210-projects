public class Job
{
    public string _Company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {

    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_Company}) {_startYear} - {_endYear} ");

    }


}