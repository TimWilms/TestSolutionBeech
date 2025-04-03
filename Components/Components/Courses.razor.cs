using Microsoft.AspNetCore.Components;
using TestSolutionBeech.Models.FEDto;
using TestSolutionBeech.Services;

namespace TestSolutionBeech.Components.Components
{
    public partial class Courses : ComponentBase
    {
        [Inject]
        protected CoursesService CourseObject { get; set; } = default!;

        protected IEnumerable<FeCourse>? _courses;

        protected override void OnInitialized()
        {
            // Retrieve data from the renamed service
            _courses = CourseObject.GetFeCourses();
        }
    }
}