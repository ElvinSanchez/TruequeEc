using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TruequeEc.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruequeEc.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil : ContentPage
    {
        private const string Url = "http://192.168.2.103:8080/registro/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<TruequeEc.Datos> _post;

        public Perfil(string user)
        {
            InitializeComponent();

            pkrProvince.Items.Add("AZUAY");
            pkrProvince.Items.Add("BOLIVAR");
            pkrProvince.Items.Add("CAÑAR");
            pkrProvince.Items.Add("CARCHI");
            pkrProvince.Items.Add("CHIMBORAZO");
            pkrProvince.Items.Add("COTOPAXI");
            pkrProvince.Items.Add("EL ORO");
            pkrProvince.Items.Add("ESMERALDAS");
            pkrProvince.Items.Add("GALAPAGOS");
            pkrProvince.Items.Add("GUAYAS");
            pkrProvince.Items.Add("IMBABURA");
            pkrProvince.Items.Add("LOJA");
            pkrProvince.Items.Add("LOS RIOS");
            pkrProvince.Items.Add("MANABI");
            pkrProvince.Items.Add("MORONA SANTIAGO");
            pkrProvince.Items.Add("NAPO");
            pkrProvince.Items.Add("ORELLANA");
            pkrProvince.Items.Add("PASTAZA");
            pkrProvince.Items.Add("PICHINCHA");
            pkrProvince.Items.Add("SANTA ELENA");
            pkrProvince.Items.Add("STO. DGO. DE LOS TSACHILAS");
            pkrProvince.Items.Add("SUCUMBIOS");
            pkrProvince.Items.Add("TUNGURAGUA");
            pkrProvince.Items.Add("ZAMORA CHINCHIPE");
        }

        private void pkrProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = pkrProvince.Items[pkrProvince.SelectedIndex];
        }

        private async void btnoBTENER_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<TruequeEc.Datos> posts = JsonConvert.DeserializeObject<List<TruequeEc.Datos>>(content);
            _post = new ObservableCollection<TruequeEc.Datos>(posts);
           // MyListView.ItemsSource = _post;
        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {

        }
    }
}