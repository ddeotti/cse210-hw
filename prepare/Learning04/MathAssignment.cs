public class MathAssignment:Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string assignmentTopic, string problems, string textBookSection):base(studentName,assignmentTopic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}