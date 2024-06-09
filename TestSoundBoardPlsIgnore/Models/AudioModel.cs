using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;

namespace TestSoundBoardPlsIgnore.Models
{
	//TODO: Check if current implementation works and if it needs rework

	public class AudioModel : IDisposable
	{
		private WaveInEvent m_waveIn;
		private WaveOutEvent m_waveOut;
		private MixingSampleProvider m_mixer;
		private BufferedWaveProvider m_bufferedWaveProvider;

		public AudioModel(string _basePath)
		{
			m_waveIn = new WaveInEvent();
			m_waveIn.WaveFormat = new WaveFormat(44100, 1);
			m_waveIn.DataAvailable += OnDataAvailable;

			m_waveOut = new WaveOutEvent();
			m_waveOut.Init(m_mixer);
			m_waveOut.Play();

			m_bufferedWaveProvider = new BufferedWaveProvider(m_waveIn.WaveFormat);
			m_mixer.AddMixerInput(m_bufferedWaveProvider);
		}

		private void OnDataAvailable(object sender, WaveInEventArgs e)
		{
			m_bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
		}

		public void PlaySound(string filePath)
		{
			
		}

		public void Dispose()
		{
			m_waveIn.Dispose();
			m_waveOut.Dispose();
		}
	}
}
