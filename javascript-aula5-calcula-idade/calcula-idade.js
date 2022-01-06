function calculaIdade(anos) {
	return `Daqui a ${anos} anos, ${this.nome} terá ${this.idade + anos} anos de idade.`;
}

let person0 = {
    nome: "João",
    idade: 34
}

let person1 = {
    nome: "Dany",
    idade: 28
}

console.log(calculaIdade.call(person0, 10));
console.log(calculaIdade.apply(person1, [10]));
