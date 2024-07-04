public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problemString;

    public MathAssignment() : base()
    {
        _textBookSection = "Unknown";
        _problemString = "Unknown";
    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problemString) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problemString = problemString;
    }

    public string GetHomeworkList()
    {
        return _textBookSection + " - " + _problemString;
    }
}