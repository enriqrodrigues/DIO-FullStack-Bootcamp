import {useState} from 'react';

function Smartcounter () {
    const [qtd, setQtd] = useState(0);

    const minusQtd = () => {
        setQtd(qtd - 1)
    }

    function zeraQtd(){
        setQtd(0)
    }

    return (
        <>
            <h2>CONTADOR COM HOOK</h2>
            <h1>{qtd}</h1>
            <button onClick={()=>setQtd(qtd+1)}> + </button>
            <button onClick={minusQtd}> - </button>
            <button onClick={zeraQtd}> Zerar </button>
        </>
    )
}

export default Smartcounter;