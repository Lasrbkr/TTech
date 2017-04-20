using System.Collections.Generic;
using Xamarin.Forms;

namespace TTech
{
    public partial class TTechPage : ContentPage
    {
        DatosProductos datosproductos = new DatosProductos();
        List<Producto> listaproductos = new List<Producto>();

        public TTechPage()
        {
            InitializeComponent();

            Appearing += TTechPage_Appearing;
        }

        async void TTechPage_Appearing(object sender, System.EventArgs e)
        {
            listaproductos = await datosproductos.SP_CargarListaProductos();
        }
    }
}