namespace WebApplication1.Models.models
{
    public class Course :BaseModel
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
