namespace wp.Views;

public partial class ContactUs : ContentPage
{
	public ContactUs()
	{
		InitializeComponent();
	}

    private async void BackButton(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}