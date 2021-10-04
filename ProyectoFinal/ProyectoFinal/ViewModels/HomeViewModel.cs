using System;
using Prism.Navigation;
using ProyectoFinal.Models;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModels
{
    public class HomeViewModel
    {
        INavigationService _navigationService;

        public Items Beach { get; set; } = new Items();
        public Items Camping { get; set; } = new Items();
        public Items Hiking { get; set; } = new Items();
        public Items Lake { get; set; } = new Items();
        public Command NavigateBeach { get; }
        public string Appname => "VacacionanDO";

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateBeach = new Command(BeachPageNav);

            Beach.Title = "Beach";
            Beach.Image = "Beach";

            Camping.Title = "Camping";
            Camping.Image = "Camping";

            Hiking.Title = "Hiking";
            Hiking.Image = "Hiking";

            Lake.Title = "Lake";
            Lake.Image = "Lake";
        }

        private async void BeachPageNav(object obj)
        {
            await _navigationService.NavigateAsync(new Uri("BeachPage", UriKind.Relative));
        }
    }
}
