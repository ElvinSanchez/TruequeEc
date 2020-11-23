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

namespace TruequeEc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MisPublicaciones : ContentPage
    {
        public MisPublicaciones(string user)
        {
            InitializeComponent();
            lblUsuario.Text = user;
            

        }
        private async void btnGet_Clicked(object sender, EventArgs e)
        {
             HttpClient client = new HttpClient();
             client.BaseAddress = new Uri("http://192.168.2.106:8080");
             string url = string.Format("/publicacion/post.php/{0}", lblUsuario.Text);
            var content = await client.GetAsync(url);
            ObservableCollection<TruequeEc.DatosPubli> _post;
            
             List<TruequeEc.DatosPubli> posts = JsonConvert.DeserializeObject < List <TruequeEc.DatosPubli >> (content.ToString());
            _post = new ObservableCollection<TruequeEc.DatosPubli>(posts);
            MyListView.ItemsSource = _post;

                
                
       

        }
    


        
    }
}