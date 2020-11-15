using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}