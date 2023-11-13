function Calcula(){
    let venome = document.getElementById("aluno").value
    let n1 =parseFloat(document.getElementById('n1').value)
    let n2 =parseFloat(document.getElementById('n2').value)
    let n3 =parseFloat(document.getElementById('n3').value)
    let media= n1 + n2 + n3
    media = media/3
    let presença = parseInt(document.getElementById("Frequencia").value)

    if(presença >= 0 && presença <=100 && n1>= 0 && n1 <= 10 && n2 >=0 && n2 <= 10 && n3>=0 && n3 <= 10)
    {
    if(presença < 75){
        document.getElementById("demo").innerHTML =  "Aluno:" + venome +  " Reprovado por frequencia"; 
    }
    else{
        if (media >= 7){
            document.getElementById('demo').innerHTML = "Aluno:" + venome + " Aprovado";
        }
        else{
            document.getElementById('demo').innerHTML = "Aluno:" + venome + " Reprovado por nota";
        }
    }
}else {
    document.getElementById('demo').innerHTML = "Insira valores válidos"
}
}