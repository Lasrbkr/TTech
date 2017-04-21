using System.Collections.Generic;

namespace TTech
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaProductos
    {
        public List<Producto> Productos { get; set; }
    }
}