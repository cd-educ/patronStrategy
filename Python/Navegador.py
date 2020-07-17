
from IArchivo import IArchivo

class Navegador:

    __strategy: IArchivo

    def setStrategy(self, strategy: IArchivo):
        self.__strategy = strategy

    def abrirArchivo(self, filename: str):
        self.__strategy.abrir(filename)