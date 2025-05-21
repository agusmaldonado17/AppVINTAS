using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Prueba1MAUI.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; }

        public LoginViewModel() =>
            LoginCommand = new Command(OnLogin);

        async void OnLogin()
        {
            // tras validar credenciales…
            await Shell.Current.GoToAsync("mainMenu");
        }
    }
}
