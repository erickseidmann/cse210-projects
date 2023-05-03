public class Job
{
    public string _Company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {

    }
    public void showJob()
    {
        Console.WriteLine($"{_Company}");
        Console.WriteLine($"{_jobTitle}");
        Console.WriteLine($"{_startYear}");
        Console.WriteLine($"{_endYear}");
    }


}