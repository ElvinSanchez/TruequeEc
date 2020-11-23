using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TruequeEc
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string user)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
            lblUser1.Text = user;
            

        }

        private async void btnPublicar_Clicked(object sender, EventArgs e)
        {
            string user1 = lblUser1.Text;
            await Navigation.PushAsync(new Publicacion(user1));
        }

        private void btnTrueque_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnMuro_Clicked(object sender, EventArgs e)
        {
            string user1 = lblUser1.Text;
            await Navigation.PushAsync(new MisPublicaciones(user1));
        }

        private async void btnPerfil_Clicked(object sender, EventArgs e)
        {
            string user1 = lblUser1.Text;
            await Navigation.PushAsync(new Models.Perfil(user1));
        }
    }
}
