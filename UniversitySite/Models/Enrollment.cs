namespace SchoolManagement.Models
{
    public class Enrollment
    {
        public int EId { get; set; }
        public string? StudentName { get; set; }
        public string? Course { get; set; }
        public DateTime EnrollDate { get; set; }
    }
}
