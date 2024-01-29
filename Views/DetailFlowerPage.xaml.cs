using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp2.Models;

namespace MauiApp2.Views;

[QueryProperty(nameof(FlowerId), "Id")]
public partial class DetailFlowerPage : ContentPage
{
    private Flower _flower;

    public string FlowerId
    {
        set
        {
            _flower = FlowerRepository.GetFlowerById(int.Parse(value));
            NameLabel.Text = _flower.Name;
            SignatureLabel.Text = _flower.Signature;
        }
    }
    
    public DetailFlowerPage()
    {
        InitializeComponent();
    }
    private void BtnEditFlower_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditFlowerPage));
    }
    private void BtnDeleteFlower_OnClicked(object sender, EventArgs e)
    {
        // throw new NotImplementedException();
    }
}