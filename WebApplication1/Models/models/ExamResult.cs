namespace WebApplication1.Models.models
{
    public class ExamResult : BaseModel
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public int Score { get; set; }
        public DateTime DateTaken { get; set; } 
    }
}
