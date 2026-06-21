using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class CourseController : Controller
    {
        private static List<Course> Courses => UniversityData.Courses;

        public IActionResult Index()
        {
            return View(Courses);
        }

        public IActionResult Create()
        {
            return View(new Course { Level = "Bachelor", Language = "English" });
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            course.CourseId = Courses.Count > 0 ? Courses.Max(c => c.CourseId) + 1 : 1;
            Courses.Add(course);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var course = Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
                return NotFound();

            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(Course course)
        {
            var existing = Courses.FirstOrDefault(c => c.CourseId == course.CourseId);
            if (existing == null)
                return NotFound();

            existing.CourseName = course.CourseName;
            existing.Duration = course.Duration;
            existing.Department = course.Department;
            existing.Credits = course.Credits;
            existing.Language = course.Language;
            existing.TuitionFee = course.TuitionFee;
            existing.Level = course.Level;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var course = Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
                return NotFound();

            Courses.Remove(course);
            return RedirectToAction(nameof(Index));
        }
    }
}
