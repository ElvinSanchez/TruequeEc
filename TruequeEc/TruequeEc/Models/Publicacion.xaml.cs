using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruequeEc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Publicacion : ContentPage
    {
        public Publicacion(string user)
        {
            InitializeComponent();
        }

        private async void btnTomarFoto_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg",
                SaveToAlbum = true,
                CompressionQuality = 75,
                CustomPhotoSize = 50,
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.MaxWidthHeight,
                MaxWidthHeight = 2000,
                DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Front
            });

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");

            Imagen.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
        }

        private async void btnSeleccionarFoto_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                return;
            }
            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

            });


            if (file == null)
                return;

            Imagen.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private async void btnPublicacion_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient regis = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("articulo", txtArticulo.Text);
                parametros.Add("descripcion", txtDescripcion.Text);
                parametros.Add("categoria", txtCategoria.Text);
                parametros.Add("foto", Imagen.ToString());
                parametros.Add("usuario", lblUser.Text);
                if (string.IsNullOrEmpty(txtArticulo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtCategoria.Text))
                {
                    await DisplayAlert("Atención", "No puede dejar casilleros vacíos", "Aceptar");
                }
                else
                {
                    regis.UploadValues("http://192.168.2.106:8080/publicacion/post.php", "POST", parametros);
                    await DisplayAlert("Mensaje", "Ingresado Correctamente", "ok");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Alerta", "Error" + ex.Message, "ok");

            }

        }
    }
}