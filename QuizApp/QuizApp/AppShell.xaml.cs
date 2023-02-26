using QuizApp.Pages;

namespace QuizApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("main", typeof(MainPage));
	}
}
