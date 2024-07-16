public class Assignment {
    private string _studentName;
    private string _assignmentTopic;
    public Assignment(string studentName, string assignmentTopic)
    {
        _studentName = studentName;
        _assignmentTopic = assignmentTopic;
    }

    public string GetSummary()
    {
        return _studentName + " - " +_assignmentTopic;
    }

   public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _assignmentTopic;
    }


}