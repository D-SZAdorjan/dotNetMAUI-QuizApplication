using QuizApp.Model;
using QuizApp.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace QuizApp.ViewModels
{
    public class QuizesViewModel : BaseViewModel
    {
        /*private ObservableCollection<Quiz> _quizes;

        private bool _isRefreshing = false;

        public bool IsRefreshing
        {
            get => IsRefreshing;
            set
            {
                if( _isRefreshing != value ) {
                    return;
                }

                _isRefreshing = value;
                PropertyChanged?.Invoke( this, new PropertyChangedEventArgs(nameof(IsRefreshing)) );
            }
        }

        private bool _isBusy = false;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if( _isBusy != value )
                {
                    return;
                }

                _isBusy = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsBusy)));
            }
        }

        private Quiz _selectedQuiz;
        public Quiz SelectedQuiz
        {
            get => _selectedQuiz;
            set
            {
                if( _selectedQuiz != value )
                {
                    return;
                }

                _selectedQuiz = value;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedQuiz)));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public QuizesViewModel()
        {
            _quizes = new ObservableCollection<Quiz>();
            LoadDataCommand = new Command( () => LoadData());
            QuizSelectedCommand = new Command(async () => await QuizSelected());
            AddNewQuizCommand = new Command(async () => await Shell.Current.GoToAsync(""));

            MessagingCenter.Subscribe<AddQuizesViewModel>(this, "refresh", async (sender) => await LoadData());

            Task.Run(LoadData());
        }

        private async Task QuizSelected()
        {
            if (SelectedQuiz == null)
            {
                return;
            }

            var navigationParameter = new Dictionary<string, object>()
            {
                { "quiz", SelectedQuiz }
            };

            await Shell.Current.GoToAsync("addquiz", navigationParameter);

            MainThread.BeginInvokeOnMainThread(() => SelectedQuiz = null);
        }

        public ObservableCollection<Quiz> Quizs 
        { 
            get => _quizes;
            set => _quizes = value;
        }

        public ICommand LoadDataCommand { get; private set; }
        public ICommand QuizSelectedCommand { get; private set; }
        public ICommand AddNewQuizCommand { get; private set; }

        public void LoadData()
        {
            if( IsBusy )
            {
                return;
            }

            try
            {
                IsRefreshing= true;
                IsBusy = true;

                var quizesCollection = QuizManager.GetAll();

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Quizs.Clear();

                    foreach (Quiz q in quizesCollection)
                    {
                        Quizs.Add(q);
                    }
                });
            }
            finally
            {
                IsRefreshing = false;
                IsBusy = false;
            }
        }*/

        public ObservableCollection<Player> Players { get; } = new();
        public Command GetPlayersCommand { get; }
        QuizService _quizService;

        public QuizesViewModel(QuizService quizService)
        {
            Title = "QuizApp";
            _quizService = quizService;
            GetPlayersCommand = new Command(async () => await GetPlayersAsync());
        }

        async Task GetPlayersAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var players = await _quizService.GetPlayers();

                if (Players.Count != 0)
                    Players.Clear();

                foreach (var player in Players)
                {
                    Players.Add(player);
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine($"Unable to get monkeys: {e.Message}");
                await Application.Current.MainPage.DisplayAlert("Error!", e.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
