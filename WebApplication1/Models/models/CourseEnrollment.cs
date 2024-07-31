namespace WebApplication1.Models.models
{
    public class CourseEnrollment : BaseModel
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
