const nums = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

const mac = {
    name: "maça",
    value: 2,
}

const lar = {
    name: "laranja",
    value: 3,
}

console.log("Array original: ")
console.log(nums);

//--------------MAP----------------
//A função recebe um array e um objeto
function mapWithThis(arr, thisArg) {
    
    //o map trabalha sobre o array através da função de callback
    return arr.map(function(item){  
        return item * this.value;   //a função usa o item do array e o valor na propriedade do objeto.
    }, thisArg);
}

console.log("Map Com This = Maça: ")
console.log(mapWithThis(nums, mac));
console.log("Map Com This = Laranja: ")
console.log(mapWithThis(nums, lar));

//A função recebe apenas um array
function mapWithoutThis(arr) {
    
    //o map trabalha sobre o array através da função de callback
    return arr.map(function(item){  
        return item * 4;   //a função usa o item do array e o valor padrão.
    });
}

console.log("Map Sem This: ")
console.log(mapWithoutThis(nums))

//--------------FILTER----------------
//função de callback dentro da função principal
function passaPar(arr) {
    return arr.filter(
        function(item){             
            if (item % 2 === 0) {
                return item;
            }
        }
    )
}

console.log("Filter (callback dentro): ");
console.log(passaPar(nums));

//função de callback fora da função principal
function passaImpar(arr) {
    return arr.filter(call);
}

function call(item){
    if (item % 2 === 1) {
        return item;
    }
}

console.log("Filter (callback fora): ");
console.log(passaImpar(nums));

//--------------REDUCE----------------
function somaTudo(arr){
    return arr.reduce(
        function(prev, current){
            //console.log({prev});
            //console.log({current});
            return prev + current;
        }
    );
}
//Como o valor de prev não foi declarado, ele usa o valor do index 0 do array como prev.

console.log("Reduce: ");
console.log(somaTudo(nums));

//Exercício com Reduce: Calcular saldo final
const listaPrecos = [25,30,43,59,18,21,15];
const saldoAtual = 250;

function saldoFinal(arr, num){
    console.log("Valor total da lista: ");
    console.log(arr.reduce(callback));
    console.log("Saldo restante: ");
    return num - arr.reduce(callback);
}

function callback(prev, current){
    return prev + current;
}

console.log("Exercício com Reduce: Calcular saldo final: ");
console.log("Saldo Atual: ");
console.log(saldoAtual);
console.log(saldoFinal(listaPrecos, saldoAtual));

//Outra forma de resolver
function saldoFinal2(num, arr){
    return arr.reduce(function(prev, current){
            return prev - current;
        }, num);  //Passamos o valor de saldo atual no prev e vamos subtraindo.
}

console.log("Saldo Atual - Resolução 2: ");
console.log(saldoFinal2(saldoAtual, listaPrecos));
