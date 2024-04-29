namespace wp.Views;

public partial class HelpPage : ContentPage
{
	public HelpPage()
	{
		InitializeComponent();
	}

    private async void BackButton(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}