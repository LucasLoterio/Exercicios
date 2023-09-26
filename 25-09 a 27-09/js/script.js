let info = [
];

function inserir(){
    let numero = parseFloat(document.getElementById("numeros").value)
        
     
       if (info.includes(numero)) {
            alert("insira um numero valido")
        }
        else{
            info.push(numero)
        }
}


function organizar(){
     
    let index = 0
    let itens =""

        while(index < info.length) {         
        itens += `<li>${info[index]} </li>
         `        
         
        index++
    }
    document.getElementsByTagName("ul")[0].innerHTML = itens;    
}


function pesquisar(input){
    let num = parseFloat(document.getElementById(`${input}`).value)
        if(info.includes(num)){
            return info.indexOf(num);
        }
        else{
            return -1;
        }
}

function bblSort() {
  
    for (var i = 0; i < info.length; i++) {
  
        
        for (var j = 0; j < (info.length - i - 1); j++) {
  
        
            if (info[j] > info[j + 1]) {
  
             
                var temp = info[j]
                info[j] = info[j + 1]
                info[j + 1] = temp
            }
        }
    }
    organizar()
}


function decrescente(){
    for (var i = 0; i < info.length; i++) {
  
        
        for (var j = 0; j < (info.length - i - 1); j++) {
  
        
            if (info[j] < info[j + 1]) {
  
             
                var temp = info[j]
                info[j] = info[j + 1]
                info[j + 1] = temp
            }
        }
    }
    organizar()
}


function excluir(){
   let excluir = pesquisar("num")
     
   info.splice(excluir, 1)

    organizar()
}


function trocar(){
    let velho = pesquisar('n1')
    let novo = document.getElementById('n2')
    
    if(pesquisar("n2") == -1){
        info[velho] = novo.value
    }

    organizar()
}

function achar(){
    let posicao = document.getElementById("posicao")
    let input = pesquisar("encontrar")


    posicao.value = input 

   
}