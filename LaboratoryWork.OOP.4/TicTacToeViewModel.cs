using System.ComponentModel;
using System.IO;

namespace LaboratoryWork.OOP._4
{
	public class TicTacToeViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private int _x = 50;
		private int _y = 80;
		private int _motion = 0;
		private int _score1;
		private int _score2;
		private int[,] _table = new int[3, 3];
		private int _win;
		private int _winx0;
		private int _winy0;
		private int _winx1;
		private int _winy1;
		private int _firstMove;

		public int X
		{
			get => _x;
			set
			{
				_x = value;
				OnPropertyChanged(nameof(X));
			}
		}

		public int Y
		{
			get => _y;
			set
			{
				_y = value;
				OnPropertyChanged(nameof(Y));
			}
		}

		public int Motion
		{
			get => _motion;
			set
			{
				_motion = value;
				OnPropertyChanged(nameof(Motion));
			}
		}

		public int Score1
		{
			get => _score1;
			set
			{
				_score1 = value;
				OnPropertyChanged(nameof(Score1));
			}
		}

		public int Score2
		{
			get => _score2;
			set
			{
				_score2 = value;
				OnPropertyChanged(nameof(Score2));
			}
		}

		public int[,] Table
		{
			get => _table;
			set
			{
				_table = value;
				OnPropertyChanged(nameof(Table));
			}
		}

		public int Win
		{
			get => _win;
			set
			{
				_win = value;
				OnPropertyChanged(nameof(Win));
			}
		}

		public int Winx0
		{
			get => _winx0;
			set
			{
				_winx0 = value;
				OnPropertyChanged(nameof(Winx0));
			}
		}

		public int Winy0
		{
			get => _winy0;
			set
			{
				_winy0 = value;
				OnPropertyChanged(nameof(Winy0));
			}
		}

		public int Winx1
		{
			get => _winx1;
			set
			{
				_winx1 = value;
				OnPropertyChanged(nameof(Winx1));
			}
		}

		public int Winy1
		{
			get => _winy1;
			set
			{
				_winy1 = value;
				OnPropertyChanged(nameof(Winy1));
			}
		}

		public int FirstMove
		{
			get => _firstMove;
			set
			{
				_firstMove = value;
				OnPropertyChanged(nameof(FirstMove));
			}
		}

		public TicTacToeViewModel()
		{
			// Инициализация
		}

		public void New()
		{
			Win = 0;
			Motion = 0;
			FirstMove = 1 - FirstMove;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Table[i, j] = 0;
				}
			}

			OnPropertyChanged(nameof(Table));
		}

		public void ResetScore()
		{
			Score1 = 0;
			Score2 = 0;
			New();
		}

		public void SaveResults()
		{
			using StreamWriter save = File.CreateText("Результаты игры.txt");
			save.WriteLine(Score1);
			save.WriteLine(Score2);
		}

		public void DeleteResults()
		{
			File.WriteAllText("Результаты игры.txt", string.Empty);
			Score1 = 0;
			Score2 = 0;
		}

		public void LoadResults()
		{
			if (File.Exists("Результаты игры.txt"))
			{
				string[] res = File.ReadAllLines("Результаты игры.txt");
				if (res.Length >= 2 && int.TryParse(res[0], out int score1) && int.TryParse(res[1], out int score2))
				{
					Score1 = score1;
					Score2 = score2;
				}
			}
		}

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}