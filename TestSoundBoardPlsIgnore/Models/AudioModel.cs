using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace TestSoundBoardPlsIgnore.Models
{
	//TODO: Check if current implementation works and if it needs rework

	public class AudioModel : IDisposable
	{
		private WaveInEvent waveIn;
		private WaveOutEvent waveOut;
		private MixingSampleProvider mixer;
		private BufferedWaveProvider bufferedWaveProvider;

		public AudioModel()
		{
			waveIn = new WaveInEvent();
			waveIn.WaveFormat = new WaveFormat(44100, 1);
			waveIn.DataAvailable += OnDataAvailable;

			waveOut = new WaveOutEvent();
			waveOut.Init(mixer);
			waveOut.Play();

			bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);
			mixer.AddMixerInput(bufferedWaveProvider);
		}

		private void OnDataAvailable(object sender, WaveInEventArgs e)
		{
			bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
		}

		public void PlaySound(string filePath)
		{
			
		}

		public void Dispose()
		{
			waveIn.Dispose();
			waveOut.Dispose();
		}
	}
}
