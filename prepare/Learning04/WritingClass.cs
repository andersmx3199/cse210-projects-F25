public class WritingClass : Assignments
{
    private string _book;

    public WritingClass(string student, string unit, string book) :base(student, unit)
    {
        _book = book;
    }

    public string GetWritingInfo()
    {
        string student = GetStudent();
        return $"{_book} by {student}";
    }
}