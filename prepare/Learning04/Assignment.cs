public class Assignment{

    protected string _studentName;
    private string _topic;


    public Assignment(string studentName, string topic){
        /*
        Constructor to get the Name of the student and the problems        
        */

        _studentName = studentName;

        _topic = topic;

    }

    public string GetSummary()
    {
        return($"{_studentName} - {_topic}");
    }



}