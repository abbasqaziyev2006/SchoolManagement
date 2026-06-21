using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class CourseController : Controller
    {
        private static readonly List<Course> _courses = new()
        {
            new Course { CourseId = 1, CourseName = "Computer Science", Duration = "4 Years" },
            new Course { CourseId = 2, CourseName = "Business Administration", Duration = "3 Years" }
        };

        public IActionResult Index()
        {
            return View(_courses);
        }

        public IActionResult Create()
        {
            return View(new Course());
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            course.CourseId = _courses.Count > 0 ? _courses.Max(c => c.CourseId) + 1 : 1;
            _courses.Add(course);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var course = _courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
                return NotFound();

            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(Course course)
        {
            var existing = _courses.FirstOrDefault(c => c.CourseId == course.CourseId);
            if (existing == null)
                return NotFound();

            existing.CourseName = course.CourseName;
            existing.Duration = course.Duration;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var course = _courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
                return NotFound();

            _courses.Remove(course);
            return RedirectToAction(nameof(Index));
        }
    }
}
