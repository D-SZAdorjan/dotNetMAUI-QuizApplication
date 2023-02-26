namespace QuizApp.Model
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Player QuizPlayer { get; set; }

        public List<Question> Questions { get; set; }
    }
}
