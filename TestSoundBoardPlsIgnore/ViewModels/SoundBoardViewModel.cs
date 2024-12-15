using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Media;
using System.Windows;
using System.Windows.Input;
using TestSoundBoardPlsIgnore.Commands;
using TestSoundBoardPlsIgnore.Models;

namespace TestSoundBoardPlsIgnore.ViewModels
{
	public class SoundBoardViewModel : BindableBase
	{
		public ObservableCollection<AudioModel> Sounds { get; set; }

		public ICommand PlaySoundCommand { get; set; }

		public SoundBoardViewModel()
		{
			Sounds = new ObservableCollection<AudioModel>() 
			{
				new AudioModel{Name= "Sound 1"},
				new AudioModel{Name= "Sound 2"},
				new AudioModel{Name= "Sound 3"},
				new AudioModel{Name= "Sound 4"},
				new AudioModel{Name= "Sound 5"},
				new AudioModel{Name= "Sound 6"},
				new AudioModel{Name= "Sound 7"},
				new AudioModel{Name= "Sound 8"},
				new AudioModel{Name= "Sound 9"},
			};

			PlaySoundCommand = new RelayCommand(PlaySound);
		}

		private void PlaySound(object parameter)
		{
			if (parameter is AudioModel audio)
			{
				try
				{
					SoundPlayer player = new SoundPlayer(audio.FilePath);
					player.Load();
					player.Play();
				}
				catch (System.Exception)
				{
					MessageBox.Show($"");
				}
			}
		}
	}
}
