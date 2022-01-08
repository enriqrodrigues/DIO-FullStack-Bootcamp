/*
Na geometria Euclidiana, um polígono regular é um polígono em que todos os ângulos são iguais e todos os lados tem o mesmo comprimento. Um polígono simples é aquele cujos segmentos de reta não se interceptam. Abaixo pode-se ver vários mosaicos feitos por polígonos regulares.

Você deve escrever um programa que, dados o número e o comprimento dos lados de um polígono regular, mostre seu perímetro.

Entrada
A entrada tem dois inteiros positivos: N e L, que são, respectivamente, o número de lados e o comprimento de cada lado de um polígono regular (3 ≤ N ≤ 1.000.000 and 1 ≤ L ≤ 4.000).

Saída
A saída é o perímetro P do polígono regular em uma única linha.

Exemplos de Entrada	Exemplos de Saída
3 1                 3
9 8                 72
1000000 1000        1000000000

Código:
let lines = gets().split("\n");
let line = lines.shift().split(' ');

//continue o seu código aqui
*/

let lines = [gets().split("\n")];
let line = lines.shift().split(' ');

let perimetro = 1;

for (i = 0; i < line.length; i++) {
    perimetro *= parseInt(line[i]);
}

print(perimetro);
