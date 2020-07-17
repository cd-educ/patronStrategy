const {IArchivo} = require("./IArchivo");

class Pdf extends IArchivo{

    abrir(filename){
        console.log("Abri el archivo Pdf de nombre '" + filename + "'");
    }

}

exports.Pdf = Pdf;