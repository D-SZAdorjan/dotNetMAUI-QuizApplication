namespace QuizApp.Model
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerString { get; set; }
        public bool isCorrect { get; set; }

        //public Question Question { get; set; }
    }
}
