﻿namespace WebApplication1.Models.models
{
    public class QuizQuestion 
    {
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
