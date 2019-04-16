using Navegador.Modelo;
using System;

namespace Navegador
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombreDoc;

            // Prueba con Word
            nombreDoc = "Hola word.doc";
            abrirArchivo(nombreDoc);

            // Prueba con Pdf
            nombreDoc = "Factura luz.pdf";
            abrirArchivo(nombreDoc);

            // Prueba con Photoshop
            nombreDoc = "Logo empresa.psd";
            abrirArchivo(nombreDoc);

            Console.ReadLine();

        }

        public static void abrirArchivo(string nombre)
        {
            var infoArchivo = nombre.Split(".");

            var nombreArchivo = infoArchivo[0];
            var extension = nombre.Split(".")[1];

            /* Con la extension detecto de que manera tengo que abrir el archivo
             * llamando a una clase determinada para hacerlo
             * */
            switch (extension)
            {
                case "doc":
                    {
                        Archivo archivo = new Word();
                        archivo.abrir(nombreArchivo);
                        break;
                    }
                case "pdf":
                    {
                        Archivo archivo = new Pdf();
                        archivo.abrir(nombreArchivo);
                        break;
                    }
                case "psd":
                    {
                        Archivo archivo = new Psd();
                        archivo.abrir(nombreArchivo);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Formato ." + extension + "no soportado");
                        break;
                    }
            }
        }

    }

}

