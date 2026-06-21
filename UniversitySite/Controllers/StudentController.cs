using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> Students => UniversityData.Students;

        public IActionResult Index()
        {
            return View(Students);
        }

        public IActionResult Details(int id)
        {
            var student = Students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        public IActionResult Create()
        {
            return View(new Student { Status = "Active", Scholarship = "None", EnrollmentYear = DateTime.Now.Year });
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.StudentId = Students.Count > 0 ? Students.Max(s => s.StudentId) + 1 : 1;
            Students.Add(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var student = Students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var existing = Students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existing == null)
                return NotFound();

            existing.StudentName = student.StudentName;
            existing.Email = student.Email;
            existing.Phone = student.Phone;
            existing.Specialty = student.Specialty;
            existing.EntranceScore = student.EntranceScore;
            existing.AnnualFee = student.AnnualFee;
            existing.City = student.City;
            existing.BirthDate = student.BirthDate;
            existing.EnrollmentYear = student.EnrollmentYear;
            existing.Status = student.Status;
            existing.GPA = student.GPA;
            existing.Scholarship = student.Scholarship;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var student = Students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
                return NotFound();

            Students.Remove(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
