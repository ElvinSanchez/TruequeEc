using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruequeEc.Metodos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Post_Insertar : ContentPage
    {
        public Post_Insertar()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("nombe",txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("correo", txtCorreo.Text);
                parametros.Add("ciudad", txtCiudad.Text);
                parametros.Add("telefono", txtTelefono.Text);

                cliente.UploadValues("http://127.0.0.1/clientes/post.php","POST",parametros);
                await DisplayAlert("Mensaje:", "Registrado", "ok");
            }
            catch(Exception ex){
                await DisplayAlert("Alerta", "Error" + ex.Message, "ok");
            }
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}