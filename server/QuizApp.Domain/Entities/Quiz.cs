using QuizApp.Domain.Auth;
using System.Collections.Generic;

namespace QuizApp.Domain.Entities
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string QuizDescription { get; set; }
        public string Title { get; set; }
        public double TotalTime { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; } 
        public List<Question> Questions { get; set; }
    }
}
