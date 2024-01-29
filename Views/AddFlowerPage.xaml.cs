namespace MauiApp2.Views;

public partial class AddFlowerPage : ContentPage
{
	public AddFlowerPage()
	{
		InitializeComponent();
	}

    private void BtnBack_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}