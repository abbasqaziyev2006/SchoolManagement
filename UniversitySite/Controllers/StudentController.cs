using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<Student> _students = new()
        {
            new Student { StudentId = 1, StudentName = "John Doe", Email = "john@email.com", Phone = "555-0101" },
            new Student { StudentId = 2, StudentName = "Jane Smith", Email = "jane@email.com", Phone = "555-0102" }
        };

        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.StudentId = _students.Count > 0 ? _students.Max(s => s.StudentId) + 1 : 1;
            _students.Add(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var existing = _students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existing == null)
                return NotFound();

            existing.StudentName = student.StudentName;
            existing.Email = student.Email;
            existing.Phone = student.Phone;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
                return NotFound();

            _students.Remove(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
