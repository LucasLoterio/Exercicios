let info = [
];

function inserir(){
    const person = {
        firstName: document.getElementById("nome").value,
        telefone: document.getElementById("contato").value,
        email: document.getElementById("email").value
        };       
     
       if (person.firstName.length > 2 && !info.includes(person.telefone)) {
           info.push(person)
       }
        else{
            alert("Insira um contato valido")
        }
}


function organizar(){
     
    let index = 0
    let itens =""

        while(index < info.length) {         
        itens += `<tr>
         <td>${info[index].firstName}</td>
         <td>${info[index].telefone}</td>
         <td>${info[index].email}</td>
         <td><button class="tabela" onclick="excluir('${[index]}')"> X </button></td>
         <td><button class="tabela"  onclick="alterar(${[index]})">Alt </button></td>
         </tr>
         `        
         
        index++
    }
    document.getElementsByTagName("tbody")[0].innerHTML = itens;    
}


function excluir(itens){
    info.splice(itens,1)
    organizar()
}
function alterar(itens){
    let veNome = document.getElementById("nome").value;
    let veTelefone = document.getElementById("contato").value;;
    let veEmail = document.getElementById("email").value;;

    if(veEmail != ""){
        info[itens].email =  veEmail
    }
    if(veNome != ""){
        
        info[itens].firstName =  veNome
    }
    if(veTelefone != ""){
        info[itens].telefone =  veTelefone
    }

    organizar() 
    

}