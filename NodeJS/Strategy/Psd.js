const {IArchivo} = require("./IArchivo");

class Psd extends IArchivo{

    abrir(filename){
        console.log("Abri el archivo Psd de nombre '" + filename + "'");
    }

}

exports.Psd = Psd;