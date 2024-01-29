using MauiApp2.Models;

namespace MauiApp2.Views;

public partial class FlowerPage : ContentPage
{
	public FlowerPage()
	{
		InitializeComponent();
        
        FlowerListView.ItemsSource = FlowerRepository.GetFlowers();
	}

    private void BtnAddFlower_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddFlowerPage));
    }

    private void BtnEditFlower_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditFlowerPage));
    }

    private async void FlowerListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (FlowerListView.SelectedItem != null)
        {
           // await Shell.Current.GoToAsync(nameof(DetailFlowerPage)); 
           await Shell.Current.GoToAsync($"{nameof(DetailFlowerPage)}?Id={((Flower)FlowerListView.SelectedItem).Id}"); 
        }
        
    }

    private void FlowerListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        FlowerListView.SelectedItem = null;
    }
}