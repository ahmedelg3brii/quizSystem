namespace WebApplication1.Models.models
{
    public class Instructor : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
