namespace wp.Views;

public partial class AboutUs : ContentPage
{
	public AboutUs()
	{
		InitializeComponent();
	}

    private async void BackButton(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}