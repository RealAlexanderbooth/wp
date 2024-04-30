namespace wp.Views;

public partial class CheckInOut : ContentPage
{
	public CheckInOut()
	{
		InitializeComponent();
	}

    private async void BackButton(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void SettingsPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Settings());
    }

    private void Home(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WelcomeOptions());
    }

    private void CheckOutConfirm(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CheckOutConfirmation());
    }
}