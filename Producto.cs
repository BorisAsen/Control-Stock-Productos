// ************* LIBRERIAS ************* //
using System;
using static System.Math;
using System.Globalization;

namespace Final_StockProductos
{
    public class Producto
    {
        // ************* ESTRUCTURAS DE DATOS ************* //
        // Tipo de producto
        public enum TipoProducto { Bebida, Galleta, Golosina };
        // Arreglos de string con valores de bebidas, galletas y golosinas para luego generar productos aleatorios
        public static string[] Bebidas = { "Coca-Cola Zero", "Pepsi Max", "Sprite Zero", "Mountain Dew", "Fanta Naranja", "Mirinda Manzana", "Lipton Ice Tea Limón", "Schweppes Tónica", "Dr. Pepper Cherry", "7UP Light" };
        public static string[] Galletas = { "Chips Ahoy Chocolate Chip", "María Integral", "Digestive Chocolate", "Oreo Golden", "Napolitana con Crema", "Príncipe Black Edition", "Tosta Rica con Leche", "Fontaneda Digestive Integral", "Cuétara Chocoflakes", "Galleta María con Chocolate" };
        public static string[] Golosina = { "Mentos Frutas", "Snickers Crunchy", "Kit Kat Chunky Peanut Butter", "Twix Cookies & Cream", "Milky Way Simply Caramel", "Haribo Happy Cola", "Chupa Chups Bubble Gum", "Skittles Wild Berry", "Nerds Rainbow", "Jelly Belly BeanBoozled" };

        // ATRIBUTOS
        private int id;
        private string nombre;
        private TipoProducto tipo;
        private double precio;
        private int stock;

        // GETTERS Y SETTERS
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public TipoProducto Tipo { get => tipo; set => tipo = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    

        // CONSTUCTOR
        public Producto(int id, string nombre , TipoProducto tipo, double precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.precio = precio;
            this.stock = stock;
        }

        // CONSTUCTOR VACIO
        public Producto()
        {
            this.id = 0;
            this.nombre = "Vacio";
            // this.tipo = null;
            this.precio = 0;
            this.stock = 0;
        }


        // METODOS
        // Mostrar un producto
        public void Mostrar()
        {
            Console.WriteLine("Producto Nro " + id);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Precio: $" + precio);
            Console.WriteLine("Stock: " + stock);
            Console.WriteLine();
        }





    }


}


