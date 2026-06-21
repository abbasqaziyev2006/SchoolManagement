namespace SchoolManagement.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string? Name { get; set; }
        public string? Course { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Department { get; set; }
        public string? Degree { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }
    }
}
