using MAUIQuizApp.Models;

namespace QuizApp.Data
{
    public static class QuizManager
    {
        public static Player GetPlayer(int id)
        {
            Player player;
            try
            {
                player = QuizData.Players[id];
                return player;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static int GetPlayerId(string playerName)
        {
            return QuizData.Players.FindIndex(e => e.UserName == playerName);
        }

        public static bool AddPlayer(string uName)
        {
            try
            {
                QuizData.Players.Add(new Player() { UserName= uName });
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static IEnumerable<Quiz> GetQuizesForPlayer(int playerId)
        {
            return QuizData.Players[playerId].quizzes.ToList();
        }
    }
}
