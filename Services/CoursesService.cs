using TestSolutionBeech.Models;
using TestSolutionBeech.Models.FEDto;

namespace TestSolutionBeech.Services;

public class CoursesService
{
    private List<Course> _coursesList = new List<Course>();
    private List<FeCourse> _fecoursesList = new List<FeCourse>();

    public List<Course> GetCourses()
    {
        var course = new Course(1, "fietsen op plat dak", 9999);
        var course2 = new Course(2, "fietsen op plat plafond", 9999);
        this._coursesList.Add(course);
        this._coursesList.Add(course2);
        
        return this._coursesList;
    }
    
    public List<FeCourse> GetFeCourses()
    {
        var course = new FeCourse(1, "fietsen op hobbelig dak");
        var course2 = new FeCourse(2, "fietsen op hobbelig plafond");
        this._fecoursesList.Add(course);
        this._fecoursesList.Add(course2);
        
        return this._fecoursesList;
    }
    
}