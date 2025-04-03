namespace TestSolutionBeech.Models;

public class Course(int courseId, string courseName, int hiddenCode)
{
    public int CourseId { get; set; } = courseId;
    public string CourseName { get; set; } = courseName;
    public int HiddenCode { get; set; } = hiddenCode;
}