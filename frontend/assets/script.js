let firstValue = document.getElementById('input1').value;
let secondValue = document.getElementById('input2').value;

document.getElementById('input1').addEventListener('change', event => {
	firstValue = event.target.value;
});

document.getElementById('input2').addEventListener('change', event => {
	secondValue = event.target.value;
});

function add() {
	console.log(firstValue);
	console.log(secondValue);
}
