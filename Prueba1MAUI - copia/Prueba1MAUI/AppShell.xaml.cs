using Microsoft.Maui.Controls;
using Prueba1MAUI.Pages;      // <— para MainMenuPage, ServicePage, AboutPage

namespace Prueba1MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("mainMenu", typeof(MainMenuPage));
            Routing.RegisterRoute("service", typeof(ServicePage));
            Routing.RegisterRoute("about", typeof(AboutPage));
        }
    }
}
