// See https://aka.ms/new-console-template for more information
using EntregaDevlights1;

ProductoRepository productoRepository = new ProductoRepository();

productoRepository.Agregar(new Producto(1, "Teclado Mecánico", 45000.50m, "Periféricos", true));
productoRepository.Agregar(new Producto(2, "Mouse Inalámbrico", 22000.00m, "Periféricos", true));
productoRepository.Agregar(new Producto(3, "Monitor 24 Pulgadas", 185000.00m, "Pantallas", true));
productoRepository.Agregar(new Producto(4, "Auriculares Gamer", 35000.00m, "Audio", false));

int opcion = 0;

do
{
    Console.WriteLine("Menu para interactuar con el repositorio:" +
        "\n1 para ingresar un producto" +
        "\n2 Mostrar todos los producos" +
        "\n3 Para buscar producto por ID" +
        "\n4 Para buscar productos por categoria" +
        "\n5 Para salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el ID del producto:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto:");
            decimal precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la categoria del producto:");
            string categoria = Console.ReadLine();
            Console.WriteLine("Ingrese si el producto esta activo (true/false):");
            bool activo = Convert.ToBoolean(Console.ReadLine());
            Producto nuevoProducto = new Producto(id, nombre, precio, categoria, activo);
            productoRepository.Agregar(nuevoProducto);
            Console.WriteLine("Producto agregado exitosamente.");
            break;
        case 2:
            List<Producto> productos = productoRepository.ObtenerTodos();
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Categoria: {producto.Categoria}, Activo: {producto.Activo}");
            }
            break;
        case 3:
            Console.WriteLine("Ingrese el ID del producto a buscar:");
            int buscarId = Convert.ToInt32(Console.ReadLine());
            Producto productoEncontrado = productoRepository.ObtenerPorId(buscarId);
            if (productoEncontrado != null)
            {
                Console.WriteLine($"ID: {productoEncontrado.Id}, Nombre: {productoEncontrado.Nombre}, Precio: {productoEncontrado.Precio}, Categoria: {productoEncontrado.Categoria}, Activo: {productoEncontrado.Activo}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado o inactivo.");
            }
            break;
        case 4:
            Console.WriteLine("Ingrese la categoria de los productos a buscar:");
            string buscarCategoria = Console.ReadLine();
            List<Producto> productosPorCategoria = productoRepository.BuscarPorCategoria(buscarCategoria);
            if (productosPorCategoria.Count == 0)
            {
                Console.WriteLine("No se encontraron productos en esa categoria o estan inactivos.");
                break;
            }
            foreach (var producto in productosPorCategoria)
            {
                Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Categoria: {producto.Categoria}, Activo: {producto.Activo}");
            }
            break;
        default:
            break;

    }
}while (opcion != 5);