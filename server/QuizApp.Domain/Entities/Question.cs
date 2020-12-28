using System.Collections.Generic;

namespace QuizApp.Domain.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionDescription { get; set; }
        public double MaxTime { get; set; }
        public string UserAnswer { get; set; }
        public string CorrectAnser { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
