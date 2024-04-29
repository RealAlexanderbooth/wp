namespace wp.Views;

public partial class Welcome : ContentPage
{
    public Welcome()
    {
        InitializeComponent();
    }

    private void WelcomeOptionsButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WelcomeOptions());
    }

    private void GetStarted(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GetStarted());
    }
}