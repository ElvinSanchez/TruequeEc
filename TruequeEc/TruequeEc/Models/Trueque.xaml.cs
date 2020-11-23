using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TruequeEc.Categorias;

namespace TruequeEc.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trueque : ContentPage
    {        
        public Trueque()
        {
            InitializeComponent();
            
        }


        private async void Coleccionables_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Coleccionables());
        }

        private async void Juegos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Juegos());
        }

        private async void Juguetes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Juguetes());
        }

        private async void Musica_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Musica());
        }

        private void guardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}