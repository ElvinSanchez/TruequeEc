using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruequeEc.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TruequeEc.Views;
using System.Collections.ObjectModel;
using System.Net.Http;

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
            string user = txtUser.Text;
            string pass = txtPass.Text;


            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                await DisplayAlert("Error", "Debe ingresar usuario y contraseña", "Aceptar");
            }
            else
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://192.168.2.106:8080");
                string url = string.Format("/registro/post.php/[0]/[1]", txtUser.Text, txtPass.Text);
                var response = await client.GetAsync(url);
                var result = response.Content.ReadAsStringAsync().Result;
          
                if (string.IsNullOrEmpty(result))
                 {
                     await DisplayAlert("Error", "Usuario o Contraseña incorrectos", "Aceptar");
                     txtPass.Text = string.Empty;
                     txtPass.Focus();
                     return;
                 }

                else
                {
                    await Navigation.PushAsync(new MainPage(user));
                }
            }       
           
            

            

            

        }
    }
    
}