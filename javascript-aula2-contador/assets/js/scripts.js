var currentNumber = document.getElementById("currentNumber");
var x = 0;

function increment() {
    x = ++x;
    currentNumber.innerHTML = x;
}

function decrement() {
    x = --x;
    currentNumber.innerHTML = x;
}
