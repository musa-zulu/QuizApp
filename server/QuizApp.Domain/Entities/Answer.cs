namespace QuizApp.Domain.Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Option { get; set; }
        public bool IsCorrect { get; set; }
    }
}
