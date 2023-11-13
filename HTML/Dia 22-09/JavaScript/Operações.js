
var n1 = 0
var n2 = 0
var op = ''

event.preventDefault()
function inserir(item){
    document.getElementById('display').value +=  item.innerHTML
}


function definirOperacao(item){
    op = item.innerHTML
    let display = document.getElementById('display')
    n1 = parseFloat(display.value)
           
    display.value = ''

}


function calcular(){
    let display = document.getElementById('display')
    n2 = parseFloat(display.value)
   
    let resultado = 0
    switch(op){
        case '+': resultado = n1 + n2; break;
        case '-': resultado = n1 - n2; break;
        case '÷': resultado = n1 / n2; break;
        case '*': resultado = n2 * n2; break;
    }

    display.value = resultado
}
