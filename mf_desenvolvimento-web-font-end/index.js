
function soma() {

    const operador1 = document.getElementById("operador1");

    const operador2 = document.getElementById("operador2");

    const resultado = document.getElementById("resultado");

    resultado.innerHTML = parseInt(operador1.value) + parseInt(operador2.value);
}

function subtracao() {

    const operador1 = document.getElementById("operador1");

    const operador2 = document.getElementById("operador2");

    const resultado = document.getElementById("resultado");

    resultado.innerHTML = parseInt(operador1.value) - parseInt(operador2.value);
}

function divisao() {

    const operador1 = document.getElementById("operador1");

    const operador2 = document.getElementById("operador2");

    const resultado = document.getElementById("resultado");

    resultado.innerHTML = parseInt(operador1.value) / parseInt(operador2.value);
}

function multiplicacao() {

    const operador1 = document.getElementById("operador1");

    const operador2 = document.getElementById("operador2");

    const resultado = document.getElementById("resultado");

    resultado.innerHTML = parseInt(operador1.value) * parseInt(operador2.value);
}
