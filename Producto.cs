// ************* LIBRERIAS ************* //
using System;
using static System.Math;
using System.Globalization;

namespace Final_StockProductos
{
    public class Producto
    {
        // ATRIBUTOS
        private int id;
        private string nombre;
        private double precio;
        private int stock;

        // GETTERS Y SETTERS
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    

        // CONSTUCTOR
        public Producto(int id, string nombre , double precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        // CONSTUCTOR VACIO
        public Producto()
        {
            this.id = 0;
            this.nombre = "Vacio";
            this.precio = 0;
            this.stock = 0;
        }


        // METODOS
        // Mostrar un producto
        public void Mostrar()
        {
            Console.WriteLine("Producto Nro " + id);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Stock: " + stock);
            Console.WriteLine();
        }





    }


}


