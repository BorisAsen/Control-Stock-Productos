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
        static string pathCSV = "./Files/Productos.csv";

        // Ruta del archivo CSV de productos con stock menor a 10
        static string pathCSV_StockBajo = "./Files/ProductosStockBajo.csv";

        // Ruta del archivo TXT para guardar los resultados
        static string pathTXT_Resultados = "./Files/Resultados.txt";

        // Creo un objeto random para generar valores aleatorios
        static Random rand = new Random();

        public static void Main(string[] args)
        {
            // ************* MAIN CODE ************* //

            Console.Clear();
            Console.WriteLine("PRACTICA C# FINAL SOCK PRODUCTOS\n");

            // Creo una lista de Productos
            List <Producto> productos = new List<Producto>();

            Producto test = new Producto();
            test.Mostrar();

            // Cargar lista de productos con los datos del archivo csv


            // Generar una lista de X nuevos productos aleatorios

            
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



    }


}


