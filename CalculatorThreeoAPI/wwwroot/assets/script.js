let firstValue = document.getElementById('input1').value;
let secondValue = document.getElementById('input2').value;
const apiUrl = 'api/Calculator';
const resultSpan = document.getElementById('result');

document.getElementById('input1').addEventListener('change', event => {
    firstValue = event.target.value;
});

document.getElementById('input2').addEventListener('change', event => {
    secondValue = event.target.value;
});

function errorMessage() {
    resultSpan.innerHTML = 'Insira valores validos.'
}

function resultMessage(data) {
    resultSpan.innerHTML = `Resultado: ${data}`
}

function add() {
    const addEndpoint = `${apiUrl}/add/${firstValue}/${secondValue}`;
    fetch(addEndpoint).then(response => response.json()).then(data => resultMessage(data)).catch(() => errorMessage());
}

function sub() {
    const addEndpoint = `${apiUrl}/sub/${firstValue}/${secondValue}`;
    fetch(addEndpoint).then(response => response.json()).then(data => resultMessage(data)).catch(() => errorMessage());
}

function mult() {
    const addEndpoint = `${apiUrl}/mult/${firstValue}/${secondValue}`;
    fetch(addEndpoint).then(response => response.json()).then(data => resultMessage(data)).catch(() => errorMessage());
}

function div() {
    const addEndpoint = `${apiUrl}/div/${firstValue}/${secondValue}`;
    fetch(addEndpoint).then(response => response.json()).then(data => resultMessage(data)).catch(() => errorMessage());
}