using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class TeacherController : Controller
    {
        private static readonly List<Teacher> _teachers = new()
        {
            new Teacher { TeacherId = 1, Name = "Dr. Alice Brown", Course = "Mathematics", Age = 45 },
            new Teacher { TeacherId = 2, Name = "Prof. Bob Wilson", Course = "Physics", Age = 52 }
        };

        public IActionResult Index()
        {
            return View(_teachers);
        }

        public IActionResult Create()
        {
            return View(new Teacher());
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            teacher.TeacherId = _teachers.Count > 0 ? _teachers.Max(t => t.TeacherId) + 1 : 1;
            _teachers.Add(teacher);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var teacher = _teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teacher == null)
                return NotFound();

            return View(teacher);
        }

        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            var existing = _teachers.FirstOrDefault(t => t.TeacherId == teacher.TeacherId);
            if (existing == null)
                return NotFound();

            existing.Name = teacher.Name;
            existing.Course = teacher.Course;
            existing.Age = teacher.Age;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var teacher = _teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teacher == null)
                return NotFound();

            _teachers.Remove(teacher);
            return RedirectToAction(nameof(Index));
        }
    }
}
