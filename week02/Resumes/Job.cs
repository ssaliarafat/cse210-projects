//Am creating the class named Job with empty variables on these first lines
public class Job       
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    //A constructor though I don't know what it does right now
    public Job()
    {

    }

    //Method to be used in displaying the job details (This is a behavior or action)
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}
