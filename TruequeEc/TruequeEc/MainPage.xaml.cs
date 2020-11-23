﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruequeEc.Models;
using Xamarin.Forms;

namespace TruequeEc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnPublicar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Publicacion());
        }

        private async void btnTrueque_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Trueque());
        }

        private void btnMuro_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnPerfil_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Models.Perfil());
        }
    }
}
