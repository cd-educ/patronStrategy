
from IArchivo import IArchivo

class Psd(IArchivo):

    def abrir(self, filename: str):

        # Aca estaria todo el algoritmo para descifrar el archivo en binario y poder abrirlo.
        print("Abri el archivo Psd de nombre '" + filename + "'")