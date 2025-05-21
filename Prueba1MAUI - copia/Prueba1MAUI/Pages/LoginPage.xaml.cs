using Prueba1MAUI.ViewModels;  // importa tu ViewModel

namespace Prueba1MAUI.Pages  // o .Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
