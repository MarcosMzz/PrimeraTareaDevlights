using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntregaDevlights1
{
    internal class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public bool Activo { get; set; }


        public Producto(int id, string nombre, decimal precio, string categoria, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            Activo = activo;
        }

    }
}
