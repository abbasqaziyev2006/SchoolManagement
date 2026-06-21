using SchoolManagement.Models;

namespace SchoolManagement.Data
{
    public static class UniversityData
    {
        public static List<Student> Students { get; } = new()
        {
            new Student
            {
                StudentId = 1,
                StudentName = "Ali Mammadov",
                Email = "ali.mammadov@unimanage.edu",
                Phone = "+994 50 123 45 67",
                Specialty = "Computer Science",
                EntranceScore = 650,
                AnnualFee = 2500,
                City = "Baku",
                BirthDate = new DateTime(2004, 3, 15),
                EnrollmentYear = 2023,
                Status = "Active",
                GPA = 3.85,
                Scholarship = "50% Scholarship"
            },
            new Student
            {
                StudentId = 2,
                StudentName = "Leyla Hasanova",
                Email = "leyla.hasanova@unimanage.edu",
                Phone = "+994 55 987 65 43",
                Specialty = "Medicine",
                EntranceScore = 680,
                AnnualFee = 3200,
                City = "Ganja",
                BirthDate = new DateTime(2003, 7, 22),
                EnrollmentYear = 2022,
                Status = "Active",
                GPA = 4.10,
                Scholarship = "Full Scholarship"
            },
            new Student
            {
                StudentId = 3,
                StudentName = "Rashad Guliyev",
                Email = "rashad.guliyev@unimanage.edu",
                Phone = "+994 70 456 78 90",
                Specialty = "Finance",
                EntranceScore = 590,
                AnnualFee = 1800,
                City = "Sumgait",
                BirthDate = new DateTime(2005, 1, 8),
                EnrollmentYear = 2024,
                Status = "Active",
                GPA = 3.40,
                Scholarship = "None"
            }
        };

        public static List<Course> Courses { get; } = new()
        {
            new Course
            {
                CourseId = 1,
                CourseName = "Computer Science",
                Duration = "4 Years",
                Department = "Information Technology",
                Credits = 240,
                Language = "English",
                TuitionFee = 2500,
                Level = "Bachelor"
            },
            new Course
            {
                CourseId = 2,
                CourseName = "Medicine",
                Duration = "6 Years",
                Department = "Faculty of Medicine",
                Credits = 360,
                Language = "English",
                TuitionFee = 3200,
                Level = "Bachelor"
            },
            new Course
            {
                CourseId = 3,
                CourseName = "Finance & Banking",
                Duration = "4 Years",
                Department = "Economics",
                Credits = 240,
                Language = "English / Azerbaijani",
                TuitionFee = 1800,
                Level = "Bachelor"
            }
        };

        public static List<Teacher> Teachers { get; } = new()
        {
            new Teacher
            {
                TeacherId = 1,
                Name = "Dr. Nigar Aliyeva",
                Course = "Programming",
                Age = 42,
                Email = "nigar.aliyeva@unimanage.edu",
                Phone = "+994 12 345 67 89",
                Department = "Computer Science",
                Degree = "PhD",
                ExperienceYears = 15,
                Salary = 2800
            },
            new Teacher
            {
                TeacherId = 2,
                Name = "Prof. Kamran Huseynov",
                Course = "Anatomy",
                Age = 55,
                Email = "kamran.huseynov@unimanage.edu",
                Phone = "+994 12 345 67 90",
                Department = "Faculty of Medicine",
                Degree = "Professor",
                ExperienceYears = 28,
                Salary = 3500
            }
        };

        public static List<Enrollment> Enrollments { get; } = new()
        {
            new Enrollment
            {
                EId = 1,
                StudentName = "Ali Mammadov",
                Course = "Computer Science",
                EnrollDate = new DateTime(2023, 9, 1),
                Semester = "Fall 2023",
                Grade = "A",
                Status = "Ongoing",
                AttendancePercent = 92
            },
            new Enrollment
            {
                EId = 2,
                StudentName = "Leyla Hasanova",
                Course = "Medicine",
                EnrollDate = new DateTime(2022, 9, 1),
                Semester = "Spring 2025",
                Grade = "A+",
                Status = "Ongoing",
                AttendancePercent = 98
            },
            new Enrollment
            {
                EId = 3,
                StudentName = "Rashad Guliyev",
                Course = "Finance & Banking",
                EnrollDate = new DateTime(2024, 9, 1),
                Semester = "Fall 2024",
                Grade = "B+",
                Status = "Ongoing",
                AttendancePercent = 85
            }
        };
    }
}
