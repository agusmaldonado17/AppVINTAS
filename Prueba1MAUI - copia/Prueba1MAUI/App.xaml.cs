namespace Prueba1MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            // Fuerza ir al login al iniciar la app
            Shell.Current.GoToAsync("//login");
        }
    }
}
