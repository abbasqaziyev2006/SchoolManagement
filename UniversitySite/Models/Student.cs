namespace SchoolManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Specialty { get; set; }
        public double EntranceScore { get; set; }
        public decimal AnnualFee { get; set; }
        public string? City { get; set; }
        public DateTime BirthDate { get; set; }
        public int EnrollmentYear { get; set; }
        public string? Status { get; set; }
        public double GPA { get; set; }
        public string? Scholarship { get; set; }
    }
}
