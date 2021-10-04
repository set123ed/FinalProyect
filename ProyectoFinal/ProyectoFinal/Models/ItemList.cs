using System;
using Xamarin.Forms;

namespace ProyectoFinal.Models
{
    public class ItemList
    {
        public ItemList(string title, string info, string image)
        {
            Title = title;
            Info = info;
            Image = image;
        }
        public string Title { get; set; }
        public ImageSource Image { get; set; }
        public string Info { get; set; }
    }
}
