using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoCIC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnentrar.Clicked += Btnentrar_Clicked;
        }

        private async void Btnentrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InicioSesion());
        }

    }
}
