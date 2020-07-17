
from Navegador import Navegador

from Psd import Psd
from Pdf import Pdf
from Word import Word

if __name__ == "__main__":

    navegador = Navegador()

    # Prueba con PDF
    navegador.setStrategy(Pdf())
    navegador.abrirArchivo("Factua luz.pdf")

    # Prueba con Word
    navegador.setStrategy(Word())
    navegador.abrirArchivo("Hola word.doc")
    
    # Prueba con Photoshop
    navegador.setStrategy(Psd())
    navegador.abrirArchivo("Logo empresa.psd")

    """ Se podria automatizar la seleccion de la estrategia creando
    un método dentro de la clase Navegador teniendo encuenta el 
    formato del archivo para saber de que tipo es y por ende con
    que algoritmo abrirlo """

    input()