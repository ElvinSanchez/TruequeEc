using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        private async void Save_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("usuario", txtUser.Text);
                parametros.Add("cedula", txtCedula.Text);
                parametros.Add("password", txtPassword.Text);
                parametros.Add("email", txtEmail.Text);
                parametros.Add("provincia", pkrProvince.SelectedItem.ToString());
                parametros.Add("ciudad", txtCity.Text);
                parametros.Add("telefono", txtPhone.Text);

                if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtProvince.Text) || string.IsNullOrEmpty(txtPhone.Text))
                {
                    await DisplayAlert("Atención", "No puede dejar casilleros vacíos", "Aceptar");
                }
                else
                {
                    cliente.UploadValues("http://192.168.2.106:8080/registro/post.php", "POST", parametros);
                    await DisplayAlert("Mensaje", "Ingresado Correctamente", "ok");
                }


            }
            catch (Exception ex)
            {
                await DisplayAlert("Alerta", "Error: " + ex.Message, "ok");
            }
            
        }    

        private void pkrProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = pkrProvince.Items[pkrProvince.SelectedIndex];
        }
    }
}

