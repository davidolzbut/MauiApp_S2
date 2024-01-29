using MauiApp2.Models;

namespace MauiApp2.Views;

public partial class FlowerPage : ContentPage
{
	public FlowerPage()
	{
		InitializeComponent();
       

        var flowers = new List<Flower>() 
        { 
        new Flower("Rododendron", "Rhaphidophora tetrasperma"),
        new Flower("Moinstera", "Philodendron Pink Princess 'M'"),
        new Flower("Kokedama", "Kokedama Crassula Hobbit"),
        new Flower("Lopatkovec", "Pilea Norfolk 'baby'"),
    
        
        };
        FlowerListView.ItemsSource = flowers;
	}

    private void BtnAddFlower_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddFlowerPage));
    }

    private void BtnEditFlower_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditFlowerPage));
    }
}