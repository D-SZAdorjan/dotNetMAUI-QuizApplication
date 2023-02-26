namespace QuizApp.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionString { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
