using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Unity;
using Prism.Ioc;
using ProyectoFinal.Views;
using ProyectoFinal.ViewModels;

namespace ProyectoFinal
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null ) : base(initializer) { }
        public config constant = new config();

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{config.ProyectTabbedPage}");
        }

        

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage,HomeViewModel>(config.HomePage);
            containerRegistry.RegisterForNavigation<ProyectTabbedPage>(config.ProyectTabbedPage);
            containerRegistry.RegisterForNavigation<BeachPage,BeachViewModel>(config.BeachPage);
            containerRegistry.RegisterForNavigation<ExplorePage>(config.ExplorePage);
        }
    }
}
