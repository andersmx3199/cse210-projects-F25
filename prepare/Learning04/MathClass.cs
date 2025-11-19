public class MathClass : Assignments
{
    private string _section;
    private string _problem;

    public MathClass(string student, string unit, string section, string problem) : base(student,unit)
    {
        _section = section;
        _problem = problem;
    }

    public string GetHomework()
    {
        return $"Section {_section} Problems {_problem}.";
    }
}