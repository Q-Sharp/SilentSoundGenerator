using System.Media;
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();

using var stream = assembly.GetManifestResourceStream("SilentSoundGenerator.silent.wav");
using var player = new SoundPlayer(stream);
player.PlayLooping();

while(true)
{
	await Task.Delay(1000);
}