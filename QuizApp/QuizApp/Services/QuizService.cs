using QuizApp.Model;
using System.Text.Json;

namespace QuizApp.Services
{
    public class QuizService
    {
        List<Player> playerList = new();

        public QuizService()
        {

        }

        public async Task<List<Player>> GetPlayers()
        {
            if (playerList.Count > 0)
                return playerList;

            using var stream = await FileSystem.OpenAppPackageFileAsync("quizappdata.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            playerList = JsonSerializer.Deserialize<List<Player>>(contents);

            return playerList;
        }
    }
}
