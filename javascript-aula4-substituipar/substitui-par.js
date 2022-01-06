//Aqui eu não altero o array original
let entrada = [1, 3, 4, 6, 80, 33, 23, 90];

function substituiPar(a) {
    if(!a) return -1;
    if(!a.length) return -1;

    let aSemPar = [];
    for(i = 0; i < a.length; i++) {
        if(a[i] % 2 !== 0) {
            aSemPar[i] = a[i];
        } else {
            aSemPar[i] = 0;
        }
    }

    return aSemPar;
}

//Aqui estamos alterando o array original.
/*function substituiPar(a) {
    if(!a) return -1;
    if(!a.length) return -1;

    for(i = 0; i < a.length; i++) {
        if(a[i] % 2 === 0) {
            a[i] = 0;
        }
    }
    return a;
}*/

console.log("Antes da função: " + entrada);

let saida = substituiPar(entrada);

console.log("Depois da função: " + entrada);
console.log("Saída: " + saida);
