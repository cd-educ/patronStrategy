
from IArchivo import IArchivo

class Word(IArchivo):

    def abrir(self, filename: str):

        # Aca estaria todo el algoritmo para descifrar el archivo en binario y poder abrirlo.
        print("Abri el archivo Word de nombre '" + filename + "'")