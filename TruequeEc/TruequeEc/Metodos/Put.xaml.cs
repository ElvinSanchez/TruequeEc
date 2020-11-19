using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruequeEc.Metodos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Put : ContentPage
    {
        private const string Url = "http://127.0.0.1/clientes/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<TruequeEc.Ws.Datos> _post;
        public Put()
        {
            InitializeComponent();
        }

        public async void get()
        {
            try
            {
                var content = await client.GetStringAsync(Url);
                List<TruequeEc.Ws.Datos> posts = JsonConvert.DeserializeObject<List<TruequeEc.Ws.Datos>>(content);
                _post = new ObservableCollection<TruequeEc.Ws.Datos>(posts);

               
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Error" + ex.Message, "ok");
            }
        }

        private async void btnEditar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var url = "http://27.0.0.1/clientes/post.php";
                HttpClient cliente = new HttpClient();
                await DisplayAlert("alerta", "Eliminado correctamente: ", "ok");

                
            
            }
            catch (Exception ex)
            {
                await DisplayAlert("alerta", "Error: " + ex.Message, "ok");
            }
        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }