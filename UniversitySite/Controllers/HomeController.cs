using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;

namespace SchoolManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentCount = UniversityData.Students.Count;
            ViewBag.CourseCount = UniversityData.Courses.Count;
            ViewBag.TeacherCount = UniversityData.Teachers.Count;
            ViewBag.EnrollmentCount = UniversityData.Enrollments.Count;
            ViewBag.AvgEntranceScore = UniversityData.Students.Count > 0
                ? Math.Round(UniversityData.Students.Average(s => s.EntranceScore), 0)
                : 0;
            ViewBag.ScholarshipCount = UniversityData.Students.Count(s => s.Scholarship != "None");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
