using WebApplication1.Models.Enums;

namespace WebApplication1.Models.models
{
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public ICollection<Choice> Choices { get; set; }
        public ICollection<QuizQuestion> QuizQuestions { get; set; }

    }
}
