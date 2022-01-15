function Counter () {
    let qtd = 0;

    function qtdPlus(){
        qtd = qtd + 1;
        document.getElementById("counter-box-without-hook").innerHTML = qtd;
    }

    function qtdMinus(){
        qtd = qtd - 1;
        document.getElementById("counter-box-without-hook").innerHTML = qtd;
    }

    function qtdZera(){
        qtd = 0;
        document.getElementById("counter-box-without-hook").innerHTML = qtd;
    }

    return (
        <>
            <h2>CONTADOR SEM HOOK</h2>
            <h1 id="counter-box-without-hook">{qtd}</h1>
            <button onClick={qtdPlus}> + </button>
            <button onClick={qtdMinus}> - </button>
            <button onClick={qtdZera}> Zerar </button>
        </>
    )
}

export default Counter;