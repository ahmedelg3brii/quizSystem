namespace WebApplication1.Models.models
{
    public class Quiz : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFinal { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
