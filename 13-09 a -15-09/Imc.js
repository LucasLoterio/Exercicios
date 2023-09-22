function CalcImc(){
    let venome = document.getElementById("Nome").value
    let alt = parseFloat(document.getElementById('altura').value)
    let peso = parseFloat(document.getElementById('peso').value)
    let imc = peso / (alt * alt)
 
    if(peso > 0 && alt >0){
    if(imc < 17){
        document.getElementById("demo").innerHTML =  "Muito abaixo do peso"; 
    }
    else{
        if(imc >= 17 && imc < 18.5 ){
            document.getElementById('demo').innerHTML = "Abaixo do peso ";
        }
        else{
            if(imc >= 18.5 && imc < 25){
                document.getElementById('demo').innerHTML = "Peso normal " ;

            }
            else{
                if(imc >= 25 && imc < 30){
                    document.getElementById('demo').innerHTML = "Acima do peso";
                }
                else{
                    if(imc >= 30 && imc < 35){
                        document.getElementById('demo').innerHTML = "Obesidade I";
                    }
                    else{
                        if(imc >=  35 && imc < 40){
                            document.getElementById('demo').innerHTML = "Obesidade II (severa)";
                        }
                       else{
                        document.getElementById('demo').innerHTML = "Obesidade III (mórbida)";
                       }
                    }
                }
            }
        }
    }   
  
} else {
    document.getElementById('demo').innerHTML = "Insira valores válidos"
}
}


