//Criação da classe.
class ContaBancaria {
    //Construtor com os parâmetros.
    constructor(agencia, numero, tipo){
        this.agencia = agencia;
        this.numero = numero;
        this.tipo = tipo;
        this._saldo = 0;    
        //sempre que um parâmetro tiver um getter/setter, usamos o "_" na frente para que a função possa usar o nome do parâmetro. Nesse caso, temos o parâmetro "_saldo" que terá a função "saldo".
    }

    //Getter e Setter de saldo.
    get saldo(){
        return this._saldo;
    }
    set saldo(valor){
        this._saldo = valor;
    }

    sacar(valor){
        if(valor > this._saldo){
            return console.log("Saldo insuficiente!");
        }
        this._saldo = this._saldo - valor;
        return this._saldo;
    }

    depositar(valor){
        this._saldo = this._saldo + valor;
        return this._saldo;
    }
}

//Criação da classe filha
class ContaCorrente extends ContaBancaria{
    constructor(agencia, numero, cartaoCredito) {
        super(agencia, numero); //puxa os atributos da classe pai.
        this.tipo = 'corrente';
        this._cartaoCredito = cartaoCredito;
    }

    get cartaoCredito(){
        return this._cartaoCredito;
    }
    set cartaoCredito(valor){
        this._cartaoCredito = valor;    //Valor: informa se a pessoa possui cartão de crédito.
    }
}

class ContaPoupança extends ContaBancaria{
    constructor(agencia, numero) {
        super(agencia, numero); //puxa os atributos da classe pai.
        this.tipo = 'poupança';
    }
}

class ContaUniversitaria extends ContaBancaria{
    constructor(agencia, numero) {
        super(agencia, numero); //puxa os atributos da classe pai.
        this.tipo = 'universitaria';
    }

    sacar(valor){
        if (valor > 500){
            return console.log("Valor inválido. Limite de saque de R$ 500,00");
        }
        this._saldo = this._saldo - valor;
        return this._saldo;
    }
}