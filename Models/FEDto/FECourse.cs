namespace TestSolutionBeech.Models.FEDto;

public class FeCourse(int courseId, string courseName)
{
    public int CourseId { get; set; } = courseId;
    public string CourseName { get; set; } = courseName;
}