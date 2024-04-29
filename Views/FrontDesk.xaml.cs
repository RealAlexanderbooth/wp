namespace wp.Views;

public partial class FrontDesk : ContentPage
{
	public FrontDesk()
	{
		InitializeComponent();
	}

    private void SettingsPage(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Settings());
    }

    private void Home(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WelcomeOptions());
    }
}