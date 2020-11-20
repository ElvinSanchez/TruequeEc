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

namespace TruequeEc.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cliente : ContentPage
    {
        private const string Url = "http://127.0.0.1/clientes/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<TruequeEc.Models.Datos> _post;
        public Cliente()
        {
            InitializeComponent();
            get();
        }

        public async void get()
        {
            try
            {
                var content = await client.GetStringAsync(Url);
                List<TruequeEc.Models.Datos> posts = JsonConvert.DeserializeObject<List<TruequeEc.Models.Datos>>(content);
                _post = new ObservableCollection<TruequeEc.Models.Datos>(posts);

                MyListView.ItemsSource = _post;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error" + ex.Message, "ok");
            }
        }
    }
}