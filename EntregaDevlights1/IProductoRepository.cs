using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaDevlights1
{
    internal interface IProductoRepository
    {
        void Agregar(Producto producto);

        List<Producto> ObtenerTodos();

        Producto ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
    }
}
