function Somar(){
    x = parseFloat(document.getElementById("x").value)
    y = parseFloat(document.getElementById("y").value)
    result = x + y
    document.getElementById("demo").innerHTML =  "Resultado = " + result; 
}

function Subtrair(){
    x = document.getElementById("x").value
    y = document.getElementById("y").value
    result = x - y;
    document.getElementById("demo").innerHTML =  "Resultado = " + result; 
}

function Dividir(){
    x = document.getElementById("x").value
    y = document.getElementById("y").value
    result = x / y;
    document.getElementById("demo").innerHTML =  "Resultado = " + result; 
}

function Mutiplicar(){
    x = document.getElementById("x").value
    y = document.getElementById("y").value
    soma = x * y;
    document.getElementById("demo").innerHTML =  "Resultado = " + soma; 
}