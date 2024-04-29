namespace wp.Views;

public partial class WelcomeOptions : ContentPage
{
	public WelcomeOptions()
	{
		InitializeComponent();
	}


    private void SettingsPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Settings());
    }

    private void CheckInOutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CheckInOut());
    }

    private void FrontDesk(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FrontDesk());
    }
}