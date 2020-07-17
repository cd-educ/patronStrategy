package navegador;

import navegador.Strategy.IArchivo;

public class Navegador {
    
    private IArchivo strategy;

    public void setStrategy(IArchivo strategy){
        this.strategy = strategy;
    }

    public void abrirArchivo(String filename){
        this.strategy.abrir(filename);
    }
    
}