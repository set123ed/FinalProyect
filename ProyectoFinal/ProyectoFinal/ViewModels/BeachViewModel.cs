using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoFinal.Models;
using Xamarin.Forms;
using ProyectoFinal.Views;
using Prism.Navigation;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProyectoFinal.ViewModels
{
    public class BeachViewModel
    {
        INavigationService _navigationService;
        public ObservableCollection<ItemList> ItemsList { get; } = new ObservableCollection<ItemList>();
        public string Appname => "VacacionanDO";
        public string Title => "Beaches";
        public ImageSource GobackImage { get; set; } = "Goback";
        public Command GobackNavigate { get; }


        public BeachViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

         
            GobackNavigate = new Command(GobackPage);

            ItemsList = new ObservableCollection<ItemList>
            {
                new ItemList ("hola","santo domingo","Goback.png"),
                new ItemList ("hola","santo domingo","Beach"),
                new ItemList ("hola","santo domingo","Beach"),
                new ItemList ("hola","santo domingo","Beach"),
                new ItemList ("hola","santo domingo","Beach"),
                new ItemList ("hola","santo domingo","Beach")

            };
        }

        private async void  GobackPage()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
