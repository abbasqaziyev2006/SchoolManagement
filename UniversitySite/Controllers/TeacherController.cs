using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class TeacherController : Controller
    {
        private static List<Teacher> Teachers => UniversityData.Teachers;

        public IActionResult Index()
        {
            return View(Teachers);
        }

        public IActionResult Create()
        {
            return View(new Teacher());
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            teacher.TeacherId = Teachers.Count > 0 ? Teachers.Max(t => t.TeacherId) + 1 : 1;
            Teachers.Add(teacher);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var teacher = Teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teacher == null)
                return NotFound();

            return View(teacher);
        }

        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            var existing = Teachers.FirstOrDefault(t => t.TeacherId == teacher.TeacherId);
            if (existing == null)
                return NotFound();

            existing.Name = teacher.Name;
            existing.Course = teacher.Course;
            existing.Age = teacher.Age;
            existing.Email = teacher.Email;
            existing.Phone = teacher.Phone;
            existing.Department = teacher.Department;
            existing.Degree = teacher.Degree;
            existing.ExperienceYears = teacher.ExperienceYears;
            existing.Salary = teacher.Salary;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var teacher = Teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teacher == null)
                return NotFound();

            Teachers.Remove(teacher);
            return RedirectToAction(nameof(Index));
        }
    }
}
