using NAudio.Wave;

ApplicationConfiguration.Initialize();
Application.Run(new SilentSoundApplicationContext());

public class SilentSoundApplicationContext : ApplicationContext
{
	private readonly NotifyIcon _trayIcon;
	private readonly CancellationTokenSource _cts;
	private readonly Task _soundTask;

	public SilentSoundApplicationContext()
	{
		_cts = new CancellationTokenSource();
		_trayIcon = new NotifyIcon()
		{
			Icon = new Icon(SystemIcons.Shield, 40, 40),
			ContextMenuStrip = new ContextMenuStrip()
			{
				Items = { new ToolStripMenuItem("Exit", null, Exit) }
			},
			Visible = true,
			Text = "Silent Sound Generator"
		};

		_soundTask = Task.Run(async () =>
		{
			var waveOut = new WaveOutEvent();
			waveOut.Init(new SilenceProvider(new WaveFormat(44100, 1)).ToSampleProvider());
			waveOut.Play();

			while(true)
			{
				await Task.Delay(1000);
			}
		});
	}

	void Exit(object? sender, EventArgs e)
	{
		_cts.Cancel();
		_cts.Dispose();
		_trayIcon.Visible = false;
		Application.Exit();
	}
}