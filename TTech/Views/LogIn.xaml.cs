#region Referencias
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;
#endregion
namespace TTech
{
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }

        async void Sesion_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                if (txtUsuario.Text.Trim().ToLower() == "admin" && txtContrasena.Text.Trim().ToLower() == "admin")
                {
                    UserDialogs.Instance.ShowLoading("Cargando...", MaskType.Gradient);

                    await Task.Delay(2000);

                    UserDialogs.Instance.HideLoading();

                    TTechPage ttech = new TTechPage();
                    Navigation.PushModalAsync(ttech, true);
                }
                else
                    UserDialogs.Instance.ShowError("Error de usuario o contraseña", 2000);
            }
        }
    }
}