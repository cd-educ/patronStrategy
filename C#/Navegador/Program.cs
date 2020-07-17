using Navegador.Strategy;
using System;

namespace Navegador
{
    class Program
    {
        static void Main(string[] args)
        {

            var navegador = new Navegador();

            // Prueba con PDF
            navegador.setStrategy(new Pdf());
            navegador.abrirArchivo("Factua luz.pdf");

            // Prueba con Word
            navegador.setStrategy(new Word());
            navegador.abrirArchivo("Hola word.doc");
            
            // Prueba con Photoshop
            navegador.setStrategy(new Psd());
            navegador.abrirArchivo("Logo empresa.psd");

            /* Se podria automatizar la seleccion de la estrategia creando
             * un método dentro de la clase Navegador teniendo encuenta el 
             * formato del archivo para saber de que tipo es y por ende con
             * que algoritmo abrirlo */

            Console.ReadLine();

        }

    }

}

