using QuizApp.Model
using QuizApp.Data;

namespace QuizApp.Pages;

[QueryProperty(nameof(UserId), "userId")]
public partial class MainPage : ContentPage
{
    private int userId;
    private List<Quiz> userQuizes;
    public int UserId
    {
        get => userId;
        set
        {
            userId = value;

            //this is a custom function to update the UI immediately
            UpdateMainUI(userId);
        }
    }

    public MainPage()
	{
		InitializeComponent();
	}

    public List<Quiz> UserQuizez
    {
        get => userQuizes;
        set => userQuizes = value;
    }

    private void UpdateMainUI(int userId)
    {
        Player currentPlayer = QuizManager.GetPlayer(userId);
        mainPageLbl.Text = currentPlayer.UserName;
        userQuizes = currentPlayer.quizzes;
    }
}