function Aumento(){
    let venome = document.getElementById("nome").value
    let salario =parseFloat(document.getElementById('salario').value)
    let status = document.getElementById("cargo").value
    let atual= salario
    let aumento=0

  
    
if(salario > 0){
    if(status == "gerente"){
        aumento = salario * 0.5
        salario = salario + aumento
        document.getElementById("demo").innerHTML =  "Seu salario atual é :" + salario + "<br>Seu salario antigo era de :"+ atual  + "<br>Seu aumento foi de :" + aumento; 
    }
    else{
        if(status == "Supervisores"){
            aumento = salario * 0.8
            salario = salario + aumento   
            document.getElementById("demo").innerHTML =  "Seu salario atual é :" + salario + "<br>Seu salario antigo era de :"+ atual  + "<br>Seu aumento foi de :" + aumento; 
        }
        else{
            if(status == "operadores"){
                aumento = salario * 0.9
                salario = salario + aumento    
                document.getElementById("demo").innerHTML =  "Seu salario atual é :" + salario + "<br>Seu salario antigo era de :"+ atual  + "<br>Seu aumento foi de :" + aumento; 
            }
            else{
                aumento = salario * 0.1

                salario = salario + aumento
                document.getElementById("demo").innerHTML =  "Seu salario atual é :" + salario + "<br>Seu salario antigo era de :"+ atual  + "<br>Seu aumento foi de :" + aumento; 
            }
        }
        
    }
    console.log(aumento) 
}
else{
    document.getElementById("demo").innerHTML =  "Salario Inválido"; 

}

}
