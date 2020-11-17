using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruequeEc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Password : ContentPage
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Actualizar_Clicked(object sender, EventArgs e)
        {
            string password = Pass.Text;
            string repassword = RePass.Text;
            string user = User.Text;

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repassword)||string.IsNullOrEmpty(user))
            {
                DisplayAlert("Advertencia", "No puede dejar casilleros vacíos", "Aceptar");
            }
            else
            {
                if (password.Equals(repassword))
                {
                    DisplayAlert("Información", "La contraseña fue actualizada exitosamente", "Aceptar");
                }
                else
                {
                    DisplayAlert("Alerta", "Las contraseñas no coinciden", "Aceptar");

                }
            }
            
        }
    }
}