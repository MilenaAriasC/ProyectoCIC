using System;

using Xamarin.Forms;

namespace ProyectoCIC
{
    public class InicioSesion : ContentPage
    {
        public InicioSesion()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

