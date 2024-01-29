using MauiApp2.Views;

namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(FlowerPage), typeof(FlowerPage));
            Routing.RegisterRoute(nameof(AddFlowerPage), typeof(AddFlowerPage));
            Routing.RegisterRoute(nameof(EditFlowerPage), typeof(EditFlowerPage));
            Routing.RegisterRoute(nameof(DetailFlowerPage), typeof(DetailFlowerPage));
        }
    }
}