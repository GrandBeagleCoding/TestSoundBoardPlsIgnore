using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Media;
using System.Windows;

namespace TestSoundBoardPlsIgnore.Models
{
	//TODO: Check if current implementation works and if it needs rework

	public class AudioModel
	{
		public string Name { get; set; } // Name des Sounds
		public string FilePath { get; set; } // Pfad zur Datei
	}
}
