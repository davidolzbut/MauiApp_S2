using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp2.Models;

namespace MauiApp2.Views;

[QueryProperty(nameof(Id), "Id")]
public partial class DetailFlowerPage : ContentPage
{
    private Flower _flower;

    public string FlowerId
    {
        set
        {
            _flower = FlowerRepository.GetFlowerById(int.Parse(value));
            NameLabel.Text = _flower.Name;
        }
    }
    
    public DetailFlowerPage()
    {
        InitializeComponent();
    }
    
}