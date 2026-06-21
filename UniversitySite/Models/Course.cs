namespace SchoolManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Duration { get; set; }
        public string? Department { get; set; }
        public int Credits { get; set; }
        public string? Language { get; set; }
        public decimal TuitionFee { get; set; }
        public string? Level { get; set; }
    }
}
