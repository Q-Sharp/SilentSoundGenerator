using System.Media;
using System.Reflection;

using var stream = Assembly.GetExecutingAssembly()
						   .GetManifestResourceStream("SilentSoundGenerator.silent.wav");

using var player = new SoundPlayer(stream);
player.PlayLooping();

while(true)
{
	await Task.Delay(1000);
}
