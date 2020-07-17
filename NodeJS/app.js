
const {Navegador} = require("./Navegador");
const {Pdf} = require("./Strategy/Pdf");
const {Psd} = require("./Strategy/Psd");
const {Word} = require("./Strategy/Word");

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