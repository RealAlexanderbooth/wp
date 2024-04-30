namespace wp.Views;

public partial class CheckOutConfirmation : ContentPage
{
	public CheckOutConfirmation()
	{
		InitializeComponent();
	}

    private void Home(object sender, EventArgs e)
    {
		Navigation.PushAsync(new WelcomeOptions());
    }
}