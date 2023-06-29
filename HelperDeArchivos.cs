// ************* LIBRERIAS ************* //
using System;
using static System.Math;
using System.Globalization;

namespace Final_StockProductos
{
    public static class HelperDeArchivos
    {
        // Funcion para traer los datos de un archivo CSV a una lista de Productos
        public static void CargarListaDesdeCSV(List<Producto> productos, string fileName)
        {
            // Definir un FileStream para abrir el archivo en modo lectura
            FileStream archivo = new FileStream(fileName, FileMode.Open);
            
            // Crear un streamreader para leer el archivo
            StreamReader stream = new StreamReader(archivo);

            // Definir la variable que contendra cada linea del archivo
            string linea;
            // Definir la variable que contendra cada campo de la linea
            string[] campos;
            // Saltear la primera linea que contiene el nombre de los campos
            stream.ReadLine();

            // Crear una instancia de NumberFormatInfo para especificar el formato decimal correcto para los valores de punto flotante
            NumberFormatInfo numberFormat = new NumberFormatInfo();
            numberFormat.NumberDecimalSeparator = ".";

            // Leer el archivo mientras haya lineas que leer
            while ((linea = stream.ReadLine()) != null)
            {
                // Separar los campos de cada linea
                campos = linea.Split(',');
                // Crear un nuevo producto con los campos de cada linea
                Producto nuevoProducto = new Producto(
                    int.Parse(campos[0]), // id
                    campos[1], // nombre
                    (Producto.TipoProducto)Enum.Parse(typeof(Producto.TipoProducto), campos[2]), // tipo
                    double.Parse(campos[3]), // precio
                    int.Parse(campos[4]) // stock
                );
                // Agregar el nuevo prodcuto a la lista de productos
                productos.Add(nuevoProducto);
            }

            // Cerrar el StreamReader para liberar los recursos asociados al archivo
            stream.Close();
        }

        // Funcion para guardar los datos de una lista en un archivo CSV sobrescribiedolo si ya existe
        public static void EscribirArchivo_Overwrite(List<Producto> productos, string fileName)
        {
            // Definir un FileStream para abrir el archivo, si ya existe se sobreescribe
            FileStream archivo = new FileStream(fileName, FileMode.Create);

            // Crear un StreamWriter para escribir en el archivo
            StreamWriter fileWriter = new StreamWriter(archivo);

            // Escribir la primera linea con los nombres de los campos
            string campos = "id,nombre,tipo,precio,stock";
            fileWriter.WriteLine(campos);

            // Recorrer la lista de productos
            foreach (Producto producto in productos)
            {
                // Construir una línea de texto con los atributos del producto
                string line = producto.Id + "," + producto.Nombre + "," + producto.Tipo + "," + producto.Precio + "," + producto.Stock;

                // Escribir la línea en el archivo
                fileWriter.WriteLine(line);
            }

            // Cerrar el StreamWriter para liberar los recursos asociados al archivo
            fileWriter.Close();
        }

        // Funcion para escribir al final del archivo si es que existe
        public static void EscribirArchivo_Append(List<Producto> productos, string fileName)
        {
            // Preguntar si el archivo ya existia y guardar la respuesta en una vble
            bool existeElArchivo = File.Exists(fileName);

            // Definir un FileStream para abrir el archivo, si ya existe se escribe al final
            FileStream archivo = new FileStream(fileName, FileMode.Append);

            // Crear un StreamWriter para escribir en el archivo
            StreamWriter fileWriter = new StreamWriter(archivo);

            // Si el archivo no existia escribir la primera linea de cabecera con los campos del producto
            if (!existeElArchivo)
            {
                string cabecera = "id,nombre,tipo,precio,stock";
                fileWriter.WriteLine(cabecera);
            }

            // recorrer la lista de productos
            foreach (Producto producto in productos)
            {
                // Construir una línea de texto con los atributos del producto
                string line = producto.Id + "," + producto.Nombre + "," + producto.Tipo + "," + producto.Precio + "," + producto.Stock;

                // Escribir la línea en el archivo
                fileWriter.WriteLine(line);
            }

            // Cerrar el StreamWriter para liberar los recursos asociados al archivo
            fileWriter.Close();
        }


        // // Funcion para guardar los resultados en un archivo txt sobrescribiendolo
        // public static void EscribirResultadosTXT_Overwrite(Personaje pMasAtaque, Personaje pMenosVida, int[] cantidadCadaClase, string fileName)
        // {
        //     // Defino un FileStream para crear el archivo, si ya existe se sobreescribe
        //     FileStream archivo = new FileStream(fileName, FileMode.Create);

        //     // Abro el archivo en modo escritura
        //     StreamWriter fileWriter = new StreamWriter(archivo);

        //     // Escribo la primera linea informativa
        //     string linea = "RESULTADOS - Relevamiento de datos";
        //     fileWriter.WriteLine(linea);

        //     // Escribo el personaje con mas ataque
        //     linea = "Personaje con mas ataque (" + pMasAtaque.Ataque + "): " + pMasAtaque.Id + " - " + pMasAtaque.NombreCompleto;
        //     fileWriter.WriteLine(linea);

        //     // Escribo el personaje con menos vida
        //     linea = "Personaje con menos vida (" + pMenosVida.Vida + "): " + pMenosVida.Id + " - " + pMenosVida.NombreCompleto;
        //     fileWriter.WriteLine(linea);

        //     // Cantidad de personajes de cada clase
        //     for (int i = 0; i < cantidadCadaClase.Length; i++)
        //     {
        //         linea = "Cantidad de personajes de la clase (" + ((Personaje.ClasePersonaje)i).ToString() + "): " + cantidadCadaClase[i];
        //         fileWriter.WriteLine(linea);
        //     }

        //     // Cierro el StreamWriter para liberar los recursos asociados al archivo
        //     fileWriter.Close();
        // }

    }



}


