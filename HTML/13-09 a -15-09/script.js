function Verificador(){
    let venome = document.getElementById("nome").value
    let veidade =document.getElementById('idade').value
    if(veidade > 0  && venome != ""){
        if(veidade < 18){
            document.getElementById("demo").innerHTML =  "É menor de idade "; 
        }
        else{
            
            document.getElementById('demo').innerHTML = " É maior de idade ";
        }
    }else if(venome = "") {
        document.getElementById('demo').innerHTML = "Insira um nome valido"
    } else{
        document.getElementById('demo').innerHTML = "Insira uma idade valida"
    }
}


