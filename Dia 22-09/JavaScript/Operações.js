
function Somar(){
    x = parseFloat(document.getElementById("x").value)
    y = parseFloat(document.getElementById("y").value)
    result = x + y
    document.getElementById("demo").innerHTML =  "Resultado = " + result; 
    event.preventDefault()
}

function Subtrair(){
    x = parseFloat(document.getElementById("x").value)
    y = parseFloat(document.getElementById("y").value)
    result = x - y;
    document.getElementById("demo").innerHTML = "Resultado = " + result; 
    event.preventDefault()
}

function Dividir(){
    x = parseFloat(document.getElementById("x").value)
    y = parseFloat(document.getElementById("y").value)
    result = x / y;
    document.getElementById("demo").innerHTML =  "Resultado = " + result;
    event.preventDefault() 
}

function Mutiplicar(){
    x = parseFloat(document.getElementById("x").value)
    y = parseFloat(document.getElementById("y").value)
    soma = x * y;
    document.getElementById("demo").innerHTML =  "Resultado = " + soma;
    event.preventDefault() 
}