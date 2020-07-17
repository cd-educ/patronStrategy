package navegador;

import java.util.Scanner;
import navegador.Strategy.*;

public class App {

    public static void main( String[] args ){

        Navegador navegador = new Navegador();

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

        // Mantengo la consola en espera para poder leer el resultado
        Scanner scanner = new Scanner(System.in); 
        scanner.nextLine();
        scanner.close();
        
    }
    
}
