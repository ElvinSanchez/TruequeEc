using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruequeEc.Categorias;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms.Internals;
using System.Globalization;

namespace TruequeEc.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Coleccionables : ContentPage
    {
        public Coleccionables()
        {
            InitializeComponent();
            
        }

        private async void Ejemplo1_Clicked(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            var position = await locator.GetPositionAsync();
            longitud.Text = position.Longitude.ToString();
            latitud.Text = position.Latitude.ToString();
        }

        private async void Buscar_Clicked(object sender, EventArgs e)
        {
          
        }
        
       

    }
}