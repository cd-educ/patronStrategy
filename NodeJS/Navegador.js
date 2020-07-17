class Navegador{

    #strategy;

    setStrategy(strategy){
        this.strategy = strategy;
    }

    abrirArchivo(filename){
        this.strategy.abrir(filename);
    }

}

exports.Navegador = Navegador;