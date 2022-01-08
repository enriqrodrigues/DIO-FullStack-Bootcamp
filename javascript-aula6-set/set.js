const meuArray = [30, 30, 40, 5, 223, 2049, 3034, 5];

function valoresUnicos(a) {
    let mySet = new Set(a);

    return [...mySet];
}

console.log(valoresUnicos(meuArray));
