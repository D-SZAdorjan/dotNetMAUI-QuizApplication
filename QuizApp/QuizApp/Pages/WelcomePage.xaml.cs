using QuizApp.Data;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace QuizApp.Pages;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
	{
		InitializeComponent();
		startBtn.Clicked += GoToMainAsync;
    }

	private async void GoToMainAsync(object? sender, EventArgs e)
	{
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        bool answer = false;
        int userId = -1;

        userId = QuizManager.GetPlayerId(givenUserName.Text);
        if (userId != -1) {
			await Shell.Current.GoToAsync($"main?userId={userId}");
        }
        else
        {
            answer = await DisplayAlert("User not found!", $"The user name provided by you wasn't found in the database" +
                $"\nWould you like to create a new user with the name \"{givenUserName.Text}\"?",
                "Yes",
                "No");
        }

        if(answer)
        {
            if( QuizManager.AddPlayer(givenUserName.Text))
            {
                Toast.Make($"New player named \"{givenUserName.Text}\" succesfully created!", ToastDuration.Short).Show();
            }
            else
            {
                Toast.Make($"Adding player \"{givenUserName.Text}\" was unsuccesfull, please try again!", ToastDuration.Short).Show();
            }
        }
    } 
}