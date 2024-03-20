public class WritingAssignment: Assignment{


    private string _titleName;
    public WritingAssignment(string name, string topic, string titleName)
        : base(name, topic)
    {
        _titleName =titleName;
    }

    public string GetWritingInformation(){
        string studentName = GetStudentName();
        return $"{_titleName} by {studentName}";
    }
}