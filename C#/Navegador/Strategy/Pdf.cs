using System;
using System.Collections.Generic;
using System.Text;

namespace Navegador.Strategy
{
    public class Pdf : IArchivo
    {

        public void abrir(string filename)
        {

            // Aca estaria todo el algoritmo para descifrar el archivo en binario y poder abrirlo.
            Console.WriteLine("Abri el archivo Pdf de nombre '" + filename + "'");

        }

    }
}
