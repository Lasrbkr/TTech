#region Referencias
using System;
using System.Net.Http;
using System.Net.Http.Headers;
#endregion
namespace TTech
{
    public class DatosConexion
    {
        #region Variables
        private static string rutaAPI = "http://www.mocky.io/v2/";
        #endregion
        #region Metodos
        public static HttpClient conexion()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(rutaAPI);
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
        #endregion
    }
}