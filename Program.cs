namespace Clase13_Manipulando_datos_con_.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Mostrar productos listados
            //List<Producto> productos1 = ProductoHandler.ObtenerProducto();

            //foreach (var producto in productos1)
            //{
            //    Console.WriteLine(producto.Description);
            //}

            //Insertar producto
            // Producto producto = new Producto();
            // producto.Description = "Pantalon jean negro";
            // producto.Costo = 1600;
            // producto.PrecioVenta = 2500;
            // producto.Stock = 13;
            // producto.IdUser = 2;

            //if(ProductoHandler.InsertarProducto(producto) >= 1)
            // {
            //     Console.WriteLine("Producto cargado");
            // }
            // else
            // {
            //     Console.WriteLine("Producto no ingresado");
            // }

            //Traer Usuario
            //UsuarioHandler.TraerUsuario("luuansaldi");

            //Mostrar productos por IDUSuario
            //List<Producto> productos = ProductoHandler.ObtenerProductoCargadoPorUsuario(2);

            //foreach (var producto in productos)
            //{
            //    Console.WriteLine(producto.Description);
            //}

            //Mostrar producto vendido por usuario
            //List<Producto> productos = ProductoVendidoHandler.ObtenerProductosVendidos(1);

            //foreach (var producto in productos)
            //{
            //    Console.WriteLine(producto.Description);
            //}

            // Mostrar ventas por usuario
            List<Venta> ventas = VentaHandler.ObtenerVentasRealizadas(1);

            foreach (var venta in ventas)
            {
                Console.WriteLine($"Venta {venta.Id}, realizada por usuario: {venta.IdUser}");
            }





        }
    }
}