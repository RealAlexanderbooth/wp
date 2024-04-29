namespace wp.Views;

public partial class GetStarted : ContentPage
{
    public GetStarted()
    {
        InitializeComponent();
    }

    private void NavigateToWelcome(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Welcome());
    }


}