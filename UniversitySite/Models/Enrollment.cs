namespace SchoolManagement.Models
{
    public class Enrollment
    {
        public int EId { get; set; }
        public string? StudentName { get; set; }
        public string? Course { get; set; }
        public DateTime EnrollDate { get; set; }
        public string? Semester { get; set; }
        public string? Grade { get; set; }
        public string? Status { get; set; }
        public int AttendancePercent { get; set; }
    }
}
