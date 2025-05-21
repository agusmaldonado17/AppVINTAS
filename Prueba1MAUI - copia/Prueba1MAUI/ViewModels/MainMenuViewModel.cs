using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prueba1MAUI.ViewModels
{
    public class MainMenuViewModel
    {
        public ICommand ToServiceCommand { get; }
        public ICommand ToAboutCommand { get; }
        public ICommand LogoutCommand { get; }

        public MainMenuViewModel()
        {
            ToServiceCommand = new Command(async () =>
                await Shell.Current.GoToAsync("service"));
            ToAboutCommand = new Command(async () =>
                await Shell.Current.GoToAsync("about"));
            LogoutCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//login"));
        }
    }

}
