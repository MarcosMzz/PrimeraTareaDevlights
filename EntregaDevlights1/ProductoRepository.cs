using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaDevlights1
{
    internal class ProductoRepository : IProductoRepository
    {

        private List<Producto> productos = new List<Producto>();

        public void Agregar(Producto producto) { 
            productos.Add(producto);
        }

        public List<Producto> ObtenerTodos() { 
            
            List<Producto> productosActivos = productos.Where(p => p.Activo).ToList();

            return productosActivos;
        }

        public Producto ObtenerPorId(int id) { 
            return productos.FirstOrDefault(p => p.Id == id && p.Activo);

        }
        public List<Producto> BuscarPorCategoria(string categoria) { 
            return productos.Where(p => p.Categoria == categoria && p.Activo).ToList();
        }

    }
}
