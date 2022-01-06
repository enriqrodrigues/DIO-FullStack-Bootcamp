function compareNumber(number1, number2) {

    if((typeof(number1) == "number") && (typeof(number2) == "number")) {

        let numberEqual = " ";
        if (number1 === number2) {
            numberEqual = " são iguais.";
        } else {
            numberEqual = " não são iguais.";
        }

        let soma = number1 + number2;

        let compare10 = " ";
        let compare20 = " ";

        if(soma < 10) {
            compare10 = " menor ";
            compare20 = " menor ";
        } else if(soma === 10) {
            compare10 = " igual ";
            compare20 = " menor ";
        } else if(soma > 10) {
            compare10 = " maior ";
                if(soma < 20) {
                compare20 = " menor ";
            } else if(soma === 20) {
                compare20 = " igual ";
            } else if(soma > 20) {
                compare20 = " maior ";
            }
        } 

        return console.log("Os números " + number1 + " e " + number2 + numberEqual + " Sua soma é " + soma + ", que é" + compare10 + "que 10 e" + compare20 + "que 20.");

    } else {
        return console.log("Valores indefinidos ou inválidos!")
    }
}

compareNumber(10, 5);