namespace WebApplication1.Models.models
{
    public class Choice :BaseModel
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }

    }
}
