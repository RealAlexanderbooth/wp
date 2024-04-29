namespace wp.Views;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    private void AccountSettings(object sender, EventArgs e)
    {
        
    }

    private void ContactUs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContactUs());
    }

    private void AboutUs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AboutUs());
    }

    private void SignOut(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GetStarted());
    }

    private async void BackButton(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void HelpButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HelpPage());
    }
}