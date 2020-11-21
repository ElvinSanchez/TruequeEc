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
        public void ClearLabels()
        {
            txtUser.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtProvince.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
        private void Save_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string cedula = txtCedula.Text;
            string pass = txtPassword.Text;
            string mail = txtEmail.Text;
            string province = txtProvince.Text;
            string city = txtCity.Text;
            string address = txtDireccion.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(mail)
                ||string.IsNullOrEmpty(cedula)|| string.IsNullOrEmpty(province) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                DisplayAlert("Atención", "No puede dejar casilleros vacíos", "Aceptar");
            }
            else
            {
                DisplayAlert("Información", "Registro guardado exitosamente", "Aceptar");
                ClearLabels();
            }
        }    

        private void pkrProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = pkrProvince.Items[pkrProvince.SelectedIndex];
        }
    }
}

