// ************* LIBRERIAS ************* //
using System;
using static System.Math;
using System.Globalization;

namespace Final_StockProductos
{
    // ************* ESTRUCTURAS DE DATOS ************* //

    class MainClass
    {
        // Ruta del archivo CSV original
        static string pathCSV = "./Archivos/Productos.csv";

        // Ruta del archivo CSV de productos con stock menor a 10
        static string pathCSV_StockBajo = "./Archivos/ProductosStockBajo.csv";

        // Ruta del archivo TXT para guardar los resultados
        static string pathTXT_Resultados = "./Archivos/Resultados.txt";

        // Creo un objeto random para generar valores aleatorios
        static Random rand = new Random();

        public static void Main(string[] args)
        {
            // ************* MAIN CODE ************* //

            Console.Clear();
            Console.WriteLine("PRACTICA C# FINAL STOCK PRODUCTOS\n");

            // Creo una lista de Productos
            List <Producto> productos = new List<Producto>();

            // Cargar lista de productos con los datos del archivo csv
            HelperDeArchivos.CargarListaDesdeCSV(productos, pathCSV);
            MostrarProductos(productos);

            // Generar una lista de X nuevos productos aleatorios
            Console.Write("Ingrese la cantidad de productos a generar: ");
            int cant = int.Parse(Console.ReadLine());
            List <Producto> productosAleatorios = new List<Producto>();
            int idUltimoProducto = productos.Last().Id; // Obtengo el id del ultimo producto para seguir con la numeracion
            GenerarXProductosAleatorios(productosAleatorios, cant, idUltimoProducto);
            MostrarProductos(productosAleatorios);
            
            // Guardar los productos creados al final del archivo csv


            // Unificar ambas listas de productos


            // Calcular el valor total del inventario


            // Encontrar el producto mas caro


            // Filtrar los productos con un stock menor a 10 y copiarlos en una lista aparte


            // Guardar la lista de productos con stock menor a 10 en un archivo csv sobreescribiendo si ya existia


            // Guardar los resultados en un archivo TXT




        }

        // ************* FUNCIONES ************* //
        // Mostrar una lista de productos
        public static void MostrarProductos (List<Producto> productos)
        {
            // Recorro la lista de productos
            foreach (Producto producto in productos)
            {
                // Mostrar el producto
                producto.Mostrar();
            }
        }

        // Generar X prodcutos aleatorios
        public static void GenerarXProductosAleatorios (List<Producto> productosAleatorios, int cant, int idStart )
        {
            Random randGen = new Random();
            // Empezar a generar ids autoincrementales a partir del id del ultimo producto
            idStart += 1;
            // Generar "cant" productos aleatorios
            for (int i = 0; i < cant; i++)
            {
                // Id continuado segun la numeracion que ya tenian los productos originales
                int id = idStart + i;
                // Tipo de producto
                Producto.TipoProducto tipo = (Producto.TipoProducto)randGen.Next(Enum.GetValues(typeof(Producto.TipoProducto)).Length);
                // Segun el tipo de producto se tomara el nombre del arreglo de nombres que corresponda
                string nombre = "";
                switch (tipo)
                {   
                    case Producto.TipoProducto.Bebida:
                        nombre = Producto.Bebidas[randGen.Next(0,Producto.Bebidas.Length)];
                        break;
                    case Producto.TipoProducto.Galleta:
                        nombre = Producto.Galletas[randGen.Next(0,Producto.Galletas.Length)];
                        break;
                    case Producto.TipoProducto.Golosina:
                        nombre = Producto.Golosina[randGen.Next(0,Producto.Golosina.Length)];
                        break;
                    default:
                        break;
                }
                // Precio
                double precio = randGen.Next(100, 1001); // Entre 100 y 1000
                
                // Stock
                int stock = randGen.Next(0,20);

                // Crear el nuevo personaje con los valores aleatorios y agregarlo a la lista 
                Producto nuevoProducto = new Producto(id, nombre, tipo, Math.Round(precio, 2), stock);
                productosAleatorios.Add(nuevoProducto);
            }
        }

    }


}


