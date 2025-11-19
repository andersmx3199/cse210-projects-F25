public class Assignments
{
    private string _unit;
    private string _student;

    public Assignments(string student, string unit){
        _student = student;
        _unit = unit;
    }

    public string GetStudent()
    {
        return _student;
    }

    public string SetUnit()
    {
        return _unit;
    }

    public string GetAllInfo()
    {
        return _student + "-" + _unit;
    }
}