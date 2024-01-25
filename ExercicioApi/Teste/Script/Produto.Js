async function cadastrarP(){
    let auxA = document.getElementById("descricao").value
    let auxS = document.getElementById("preco").value
    let auxD = document.getElementById("estoque").value
    let auxF = document.getElementById("categoria").value

    let obj = 
    {
        descricao: auxA,
        preco: auxS,
        estoque: auxD,
        categoria: auxF
    }
    if(auxA != "" && auxS !="" && auxD != "" && auxF != "")
    {
        await fetch('http://localhost:5063/api/Produtoes',
        {
            method: "POST",
            headers: {'Authorization': 'Bearer ' + token,'Content-Type' : 'application/json'},
            body: JSON.stringify(obj)
        })

    }
}