const {IArchivo} = require("./IArchivo");

class Word extends IArchivo{

    abrir(filename){
        console.log("Abri el archivo Word de nombre '" + filename + "'");
    }

}

exports.Word = Word;