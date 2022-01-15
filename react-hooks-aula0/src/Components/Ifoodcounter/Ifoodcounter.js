import React, {useState, useEffect} from "react";
import '../Ifoodcounter/Ifoodcounter.css';

export default function Ifoodcounter() {

    const [value, setValue] = useState(1)
    const [btnStyle, setBtnStyle] = useState("counter-button-minus-active")

    useEffect(()=>{
        document.getElementById("moeda").innerHTML = value*2;
    },[value])

    function down(){
        if(value <= 1) {
            setBtnStyle("counter-button-minus-desactive")
        }
        if(value > 0) {
            setValue(value - 1)
        }
    }

    function up(){
        setValue(value + 1)
        if(value === 0){
            setBtnStyle("counter-button-minus-active")
        }
    }

    return (
        <>
            <h2>CONTADOR DO IFOOD</h2>
            <div className="countex-wrapper">
                <button
                    className={btnStyle}
                    onClick={down}>
                    - </button>
                <p>{value}</p>
                <button
                    className="counter-button-plus-active"
                    onClick={up}>
                    + </button>
            </div>
            <h3>Dobra:</h3>
            <p id="moeda"></p>
        </>
    )
}