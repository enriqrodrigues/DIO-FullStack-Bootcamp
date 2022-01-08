const teste = [1, 2, 3];

function validarArray(array, tamanho) {

    try {
        if(!array || !tamanho) throw new ReferenceError("Um ou mais parâmetros não foi enviado ou o valor recebido é inválido!");

        if(typeof(array) !== 'object') throw new TypeError("Array inválido! Utilizar array do tipo object!")
        ;
    
        if(typeof(tamanho) !== 'number') throw new TypeError("Tamanho inválido! Utilizar um número inteiro!");
    
        if(array.length !== tamanho) throw new RangeError("Array não corresponde ao tamanho informado!")
        
        return array;

    } catch (error) {
        if(error instanceof ReferenceError) {
            console.log("RefenceError!");
            console.log(error.message);
        } else
        if(error instanceof TypeError) {
            console.log("TypeError!");
            console.log(error.message);
        } else
        if(error instanceof RangeError) {
            console.log("RangeError!");
            console.log(error.message);
        } else {
            console.log("Erro não esperado! " + error.message)
        }
    }
}
console.log(validarArray(teste, 3));
