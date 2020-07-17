using Navegador.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navegador
{
    public class Navegador
    {

        private IArchivo strategy;

        public void setStrategy(IArchivo strategy){
            this.strategy = strategy;
        }

        public void abrirArchivo(string filename){
            strategy.abrir(filename);
        }

    }

}
