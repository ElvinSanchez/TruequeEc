using System;
using System.Collections.Generic;
using System.Linq;
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
        public Perfil()
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

    }
}