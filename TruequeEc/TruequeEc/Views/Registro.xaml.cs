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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
        public void ClearLabels()
        {
            Code.Text = string.Empty;
            User.Text = string.Empty;
            Password.Text = string.Empty;
            Email.Text = string.Empty;
            City.Text = string.Empty;

        }
        private void Save_Clicked(object sender, EventArgs e)
        {
            string user = User.Text;
            string pass = Password.Text;
            string mail = Email.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(mail))
            {
                DisplayAlert("Atención", "No puede dejar casilleros vacíos", "Aceptar");
            }
            else
            {
                DisplayAlert("Información", "Registro guardado exitosamente", "Aceptar");
                ClearLabels();
            }
        }
    }
}