using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class EnrollmentController : Controller
    {
        private static List<Enrollment> Enrollments => UniversityData.Enrollments;

        public IActionResult Index()
        {
            return View(Enrollments);
        }

        public IActionResult Create()
        {
            return View(new Enrollment { Status = "Ongoing", EnrollDate = DateTime.Today });
        }

        [HttpPost]
        public IActionResult Create(Enrollment enrollment)
        {
            enrollment.EId = Enrollments.Count > 0 ? Enrollments.Max(e => e.EId) + 1 : 1;
            Enrollments.Add(enrollment);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var enrollment = Enrollments.FirstOrDefault(e => e.EId == id);
            if (enrollment == null)
                return NotFound();

            return View(enrollment);
        }

        [HttpPost]
        public IActionResult Edit(Enrollment enrollment)
        {
            var existing = Enrollments.FirstOrDefault(e => e.EId == enrollment.EId);
            if (existing == null)
                return NotFound();

            existing.StudentName = enrollment.StudentName;
            existing.Course = enrollment.Course;
            existing.EnrollDate = enrollment.EnrollDate;
            existing.Semester = enrollment.Semester;
            existing.Grade = enrollment.Grade;
            existing.Status = enrollment.Status;
            existing.AttendancePercent = enrollment.AttendancePercent;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var enrollment = Enrollments.FirstOrDefault(e => e.EId == id);
            if (enrollment == null)
                return NotFound();

            Enrollments.Remove(enrollment);
            return RedirectToAction(nameof(Index));
        }
    }
}
