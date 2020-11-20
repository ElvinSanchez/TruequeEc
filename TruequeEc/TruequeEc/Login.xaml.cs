using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruequeEc.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TruequeEc.Views;

namespace TruequeEc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Registro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());         
        }

        private async void CambioPassword_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Password());
        }

        private async void Iniciar_Clicked(object sender, EventArgs e)
        {
            string user = User.Text;
            string pass = Pass.Text;

            if(string.IsNullOrEmpty(user)|| string.IsNullOrEmpty(pass))
            {
                await DisplayAlert("Error", "Debe ingresar usuario y contraseña", "Aceptar");
            }
            else
            {
                if(user.Equals("admin")&&pass.Equals("admin"))
                {
                    await Navigation.PushAsync(new Perfil());
                }
                else
                {
                    await DisplayAlert("Error", "Usuario o Contraseña incorrectos", "Aceptar");
                }
                
            }
        }
    }
}