using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class EnrollmentController : Controller
    {
        private static readonly List<Enrollment> _enrollments = new()
        {
            new Enrollment { EId = 1, StudentName = "John Doe", Course = "Computer Science", EnrollDate = new DateTime(2025, 9, 1) },
            new Enrollment { EId = 2, StudentName = "Jane Smith", Course = "Business Administration", EnrollDate = new DateTime(2025, 9, 1) }
        };

        public IActionResult Index()
        {
            return View(_enrollments);
        }

        public IActionResult Create()
        {
            return View(new Enrollment());
        }

        [HttpPost]
        public IActionResult Create(Enrollment enrollment)
        {
            enrollment.EId = _enrollments.Count > 0 ? _enrollments.Max(e => e.EId) + 1 : 1;
            _enrollments.Add(enrollment);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var enrollment = _enrollments.FirstOrDefault(e => e.EId == id);
            if (enrollment == null)
                return NotFound();

            return View(enrollment);
        }

        [HttpPost]
        public IActionResult Edit(Enrollment enrollment)
        {
            var existing = _enrollments.FirstOrDefault(e => e.EId == enrollment.EId);
            if (existing == null)
                return NotFound();

            existing.StudentName = enrollment.StudentName;
            existing.Course = enrollment.Course;
            existing.EnrollDate = enrollment.EnrollDate;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var enrollment = _enrollments.FirstOrDefault(e => e.EId == id);
            if (enrollment == null)
                return NotFound();

            _enrollments.Remove(enrollment);
            return RedirectToAction(nameof(Index));
        }
    }
}
