using Prueba1MAUI.ViewModels;  // <— para MainMenuViewModel

namespace Prueba1MAUI.Pages
{
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
            BindingContext = new MainMenuViewModel();
        }
    }
}
