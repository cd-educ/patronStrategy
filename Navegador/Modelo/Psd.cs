using System;
using System.Collections.Generic;
using System.Text;

namespace Navegador.Modelo
{
    public class Psd : Archivo
    {

        public Psd(){}

        public void abrir(string nombre)
        {

            // Aca estaria todo el algoritmo para descifrar el archivo en binario y poder abrirlo.
            Console.WriteLine("Abri el archivo Psd de nombre '" + nombre + "'");

        }

    }
}
