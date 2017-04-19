using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TTech
{
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }

        void Sesion_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                if (txtUsuario.Text.Trim() == "admin" && txtContrasena.Text.Trim() == "admin")
                {
                    DisplayAlert("Bienvenido", "Cargando Datos", "OK");
                }
                else
                    DisplayAlert("Error", "Error de usuario o contraseña", "OK");
            }
        }
    }
}