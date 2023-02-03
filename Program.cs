using Clase13_Manipulando_datos_con_.NET.Handlers;
using Clase13_Manipulando_datos_con_.NET.Modelos;

namespace Clase13_Manipulando_datos_con_.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Mostrar productos listados
            List<Producto> productos = ProductoHandler.ObtenerProducto();

            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Description);
            }

            //Insertar producto
            Producto producto = new Producto();
            producto.Description = "Pantalon jean negro";
            producto.Costo = 1600;
            producto.PrecioVenta = 2500;
            producto.Stock = 13;
            producto.IdUser = 2;

            if (ProductoHandler.InsertarProducto(producto) >= 1)
            {
                Console.WriteLine("Producto cargado");
            }
            else
            {
                Console.WriteLine("Producto no ingresado");
            }

            //Traer Usuario
            UsuarioHandler.TraerUsuario("tcasazza");

            //Mostrar productos por IDUSuario
            List<Producto> productos1 = ProductoHandler.ObtenerProductoCargadoPorUsuario(2);

            foreach (var producto in productos1)
            {
                Console.WriteLine(producto.Description);
            }

            //Mostrar producto vendido por usuario
            List<Producto> productos2 = ProductoVendidoHandler.ObtenerProductosVendidos(1);

            foreach (var producto in productos2)
            {
                Console.WriteLine(producto.Description);
            }

            // Mostrar ventas por usuario
            List<Venta> ventas = VentaHandler.ObtenerVentasRealizadas(1);

            foreach (var venta in ventas)
            {
                Console.WriteLine($"Venta {venta.Id}, realizada por usuario: {venta.IdUser}");
            }

            //Login devuelve usuario
            Usuario usuario = UsuarioHandler.Login("eperez", "SoyErnestoPerez");
            if (usuario.Username != null)
            {
                Console.WriteLine($"Bienvenido {usuario.Username}");
            }
            else
            {
                Console.WriteLine("El ingreso no fue realizado");
            }
           





        }
    }
}