public class Assignment{


    private string _topic;
    private string _studentName;
    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }
    public string GetSummary(){
        string returnSummary = $"{_studentName} - {_topic}";
        return returnSummary;
    }
    public string GetStudentName(){
        return $"{_studentName}";
    }
}
