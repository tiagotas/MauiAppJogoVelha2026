using Microsoft.Extensions.DependencyInjection;

namespace MauiAppJogoVelha2026
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var w = new Window(new AppShell());
            w.Height = 750;
            w.Width = 1080;

            return w;
        }
    }
}