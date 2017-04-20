#region Referencias
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
#endregion
namespace TTech
{
    public class DatosProductos
    {
        #region Metodos
        public Task<List<Producto>> SP_CargarListaProductos()
        {
            return Task.Run(async () =>
            {
                List<Producto> lista = new List<Producto>();
                try
                {
                    using (var client = DatosConexion.conexion())
                    {
                        HttpResponseMessage response = await client.GetAsync("58f687dc100000ce0124eee9");
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            content = content.Replace("},\n    ]", "}]");
                            content = content.Replace("\",\n        }", "\"}");
                            content = DependencyService.Get<IJavaScriptStringEncoder>().EncodeString(content);
                            var obj = JsonConvert.DeserializeObject<Productos>(content);

                            lista = obj.Lista;
                        }
                    }
                    return lista ?? new List<Producto>();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return lista ?? new List<Producto>();
                }
            });
        }
        #endregion
    }
}