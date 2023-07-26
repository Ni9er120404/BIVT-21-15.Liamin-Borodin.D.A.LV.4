using System.Windows;

namespace LaboratoryWork.OOP._4
{
	public partial class MainWindow : Window
	{
		private readonly TicTacToeViewModel _viewModel;

		public MainWindow()
		{
			InitializeComponent();
			_viewModel = new TicTacToeViewModel();
			DataContext = _viewModel;
		}

		private void NewGameMenuItemClick(object sender, RoutedEventArgs e)
		{
			_viewModel.New();
		}

		private void RebootGameMenuItemClick(object sender, RoutedEventArgs e)
		{
			_viewModel.ResetScore();
		}

		private void SaveGameMenuItemClick(object sender, RoutedEventArgs e)
		{
			_viewModel.SaveResults();
		}

		private void DeleteResultsMenuItemClick(object sender, RoutedEventArgs e)
		{
			_viewModel.DeleteResults();
		}

		private void LoadLastSaveMenuItemClick(object sender, RoutedEventArgs e)
		{
			_viewModel.LoadResults();
		}

		private void NewGameButtonClick(object sender, RoutedEventArgs e)
		{
			_viewModel.New();
		}

		private void ResetScoreButtonClick(object sender, RoutedEventArgs e)
		{
			_viewModel.ResetScore();
		}
	}
}