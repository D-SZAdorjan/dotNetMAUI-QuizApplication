namespace QuizApp.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public List<Quiz> quizzes { get; set; }

        /*public Player(int id, string userName, int level, int experience, List<Quiz> quizzes)
        {
            Id = id;
            UserName = userName;
            Level = level;
            Experience = experience;
            //this.quizzes = quizzes;
        }*/
    }
}
