using AppAmbit;

namespace AppAmbit.Victor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnTrackEventClicked(object? sender, EventArgs e)
	{
		try
		{
			Analytics.TrackEvent("Button Clicked", new Dictionary<string, string> 
			{ 
				{ "Button", "TrackEvent" },
				{ "Timestamp", DateTime.UtcNow.ToString("O") }
			});
			StatusLabel.Text = "✓ Event tracked: 'Button Clicked'";
			StatusLabel.TextColor = Colors.Green;
		}
		catch (Exception ex)
		{
			StatusLabel.Text = $"✗ Error: {ex.Message}";
			StatusLabel.TextColor = Colors.Red;
		}
	}

	private void OnTrackEventWithPropsClicked(object? sender, EventArgs e)
	{
		try
		{
			Analytics.TrackEvent("Audio started", new Dictionary<string, string> 
			{ 
				{ "Category", "Music" },
				{ "FileName", "favorite.mp3" },
				{ "Platform", DeviceInfo.Platform.ToString() },
				{ "Version", AppInfo.VersionString }
			});
			StatusLabel.Text = "✓ Event tracked: 'Audio started' with properties";
			StatusLabel.TextColor = Colors.Green;
		}
		catch (Exception ex)
		{
			StatusLabel.Text = $"✗ Error: {ex.Message}";
			StatusLabel.TextColor = Colors.Red;
		}
	}

	private void OnLogErrorClicked(object? sender, EventArgs e)
	{
		try
		{
			Crashes.LogError("This is a test error message for debugging");
			StatusLabel.Text = "✓ Error logged successfully";
			StatusLabel.TextColor = Colors.Green;
		}
		catch (Exception ex)
		{
			StatusLabel.Text = $"✗ Error: {ex.Message}";
			StatusLabel.TextColor = Colors.Red;
		}
	}

	private void OnLogWarningClicked(object? sender, EventArgs e)
	{
		try
		{
			Crashes.LogError("Warning: This is a test warning message");
			StatusLabel.Text = "✓ Warning logged successfully";
			StatusLabel.TextColor = Colors.Green;
		}
		catch (Exception ex)
		{
			StatusLabel.Text = $"✗ Error: {ex.Message}";
			StatusLabel.TextColor = Colors.Red;
		}
	}

	private void OnTestCrashClicked(object? sender, EventArgs e)
	{
		try
		{
			StatusLabel.Text = "Crashing app to test crash reporting...";
			StatusLabel.TextColor = Colors.Orange;
			
			// Force a crash to test crash reporting
			// Note: Crashes are reported on the next app launch
			throw new Exception("Test crash - AppAmbit SDK Crash Reporting Test");
		}
		catch
		{
			// Re-throw to actually crash the app
			StatusLabel.Text = "Crashing...";
			throw;
		}
	}
}
