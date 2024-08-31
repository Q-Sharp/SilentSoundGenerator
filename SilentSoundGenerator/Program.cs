using NAudio.Wave;

var waveOut = new WaveOutEvent();
waveOut.Init(new SilenceProvider(new WaveFormat(44100, 1)).ToSampleProvider());
waveOut.Play();

while(true)
{
	await Task.Delay(1000);
}
