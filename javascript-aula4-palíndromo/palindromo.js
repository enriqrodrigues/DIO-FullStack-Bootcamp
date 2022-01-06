var teste = "rsoma me tem amor";

//Solução 1
function palindromo(palavra) {
    if(!palavra) return "Frase inválida!";

    let p = palavra.replaceAll(" ", "")
    let pInvertido = palavra.replaceAll(" ", "").split("").reverse().join("");

    //console.log(p);
    //console.log(pInvertido);

    if (p === pInvertido) {
        return "A frase: " + palavra + ". É um palíndromo";
    } else {
        return "A frase: " + palavra + ". Não é um palíndromo";
    }
}

//Solução 2
function palindromo1(palavra) {
    if(!palavra) return "Frase inválida!";

    let p = palavra.replaceAll(" ", "")
    let pInvertido = palavra.replaceAll(" ", "").split("").reverse().join("");

    let saoIguais = true; 

    for (i = 0; i < p.length ; i++){
        if (p[i] === pInvertido[i]) {
            saoIguais *= true;
        } else {
            saoIguais *= false;
        }
        //console.log(saoIguais);
    }

    if (saoIguais) {
        return "A frase: " + palavra + ". É um palíndromo";
    } else {
        return "A frase: " + palavra + ". Não é um palíndromo";
    }
}

//Solução 3
function palindromo2(palavra) {
    if(!palavra) return "Frase inválida!";

    let p = palavra.replaceAll(" ", "")
    //let pInvertido = palavra.replaceAll(" ", "").split("").reverse().join("");

    for (i = 0; i < p.length / 2; i++){
        if (p[i] !== p[p.length - 1 - i]) {
            return "A frase: " + palavra + ". Não é um palíndromo";
        }
    }
    return "A frase: " + palavra + ". É um palíndromo";
}   
        
console.log(palindromo(teste));
console.log(palindromo1(teste));
console.log(palindromo2(teste));
