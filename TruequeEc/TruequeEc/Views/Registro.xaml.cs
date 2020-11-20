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
            pkrGenero.Items.Add("MASCULINO");
            pkrGenero.Items.Add("FEMENINO");

            pkrProvincia.Items.Add("AZUAY");
            pkrProvincia.Items.Add("BOLIVAR");
            pkrProvincia.Items.Add("CAÑAR");
            pkrProvincia.Items.Add("CARCHI");
            pkrProvincia.Items.Add("CHIMBORAZO");
            pkrProvincia.Items.Add("COTOPAXI");
            pkrProvincia.Items.Add("EL ORO");
            pkrProvincia.Items.Add("ESMERALDAS");
            pkrProvincia.Items.Add("GALAPAGOS");
            pkrProvincia.Items.Add("GUAYAS");
            pkrProvincia.Items.Add("IMBABURA");
            pkrProvincia.Items.Add("LOJA");
            pkrProvincia.Items.Add("LOS RIOS");
            pkrProvincia.Items.Add("MANABI");
            pkrProvincia.Items.Add("MORONA SANTIAGO");
            pkrProvincia.Items.Add("NAPO");
            pkrProvincia.Items.Add("ORELLANA");
            pkrProvincia.Items.Add("PASTAZA");
            pkrProvincia.Items.Add("PICHINCHA");
            pkrProvincia.Items.Add("SANTA ELENA");
            pkrProvincia.Items.Add("STO. DGO. DE LOS TSACHILAS");
            pkrProvincia.Items.Add("SUCUMBIOS");
            pkrProvincia.Items.Add("TUNGURAGUA");
            pkrProvincia.Items.Add("ZAMORA CHINCHIPE");
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

        private void pkrGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            var genero = pkrGenero.Items[pkrGenero.SelectedIndex];
        }

        private void pkrProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = pkrProvincia.Items[pkrProvincia.SelectedIndex];
        }
    }
}

