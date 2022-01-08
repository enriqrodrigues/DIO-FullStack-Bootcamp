/*
Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.

Entrada
A entrada contém um valor inteiro N (5 < N < 2000).

Saída
Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 1000000 o que ocasionará resposta errada. Neste caso, configure a precisão adequadamente para que isso não ocorra.

Exemplo de Entrada	
6

Exemplo de Saída
2^2 = 4
4^2 = 16
6^2 = 36
 
Código:
let lines = gets().split('\n');

var N = parseInt(lines.shift());
for (         ) {
	if (      ) print(        );    //escreva sua lógica nos espaços em branco
}

*/

let lines = gets().split('\n');

var N = parseInt(lines.shift());
for (let i = 1; i <= N; i++) {
	if (i % 2 === 0) print(i + "^2 = " + i**2);    //escreva sua lógica nos espaços em branco
}