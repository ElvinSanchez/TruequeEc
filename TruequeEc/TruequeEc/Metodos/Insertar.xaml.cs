using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
namespace TruequeEc.Metodos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insertar : ContentPage
    {
        public Insertar()
        {
            InitializeComponent();
        }


        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {

                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", code.Text);
                parametros.Add("usuario", user.Text);
                parametros.Add("contrasena", password.Text);
                parametros.Add("correo", email.Text);
                parametros.Add("ciudad", city.Text);
                cliente.UploadValues("http://192.168.0.12/moviles/post.php", "POST", parametros);
                await DisplayAlert("Alerta", "Dato ingresado correctamente", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Alerta", "ERROR: " + ex.Message, "OK");
            }
        }
    }
}