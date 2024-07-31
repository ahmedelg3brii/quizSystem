using WebApplication1.Models.models;

namespace WebApplication1.Models.models
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        public ICollection<ExamResult> ExamResults { get; set; }
    }
}
