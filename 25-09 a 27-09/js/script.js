let info = [
];

function inserir(){
    let numero = parseInt(document.getElementById("numeros").value) 
        
     
       if (!info.includes(numero)) {
           info.push(numero)
       }
        else{
            alert("insira um numero valido")
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