async function cadastrar()
    {
        let auxU = document.getElementById("user").value
        let auxS = document.getElementById("senha").value
        let cargo = document.getElementsByName('cargo')
        let resultado = document.querySelector("#resultados")
        let auxR = ""
        if (cargo[0].checked == true){
            auxR = "admin"
        }
        else if (cargo[1].checked == true){
            auxR = "gerente"
        }
        else if (cargo[2].checked == true){
            auxR = "funcionario"
        }
        let obj = 
        {
            username: auxU,
            password: auxS,
            role: auxR
        }
        if(auxU != "" && auxS !="" && auxR != "")
        {
            await fetch('http://localhost:5063/api/Users',
            {
                method: "POST",
                headers: {'Authorization': 'Bearer ' + token,'Content-Type' : 'application/json'},
                body: JSON.stringify(obj)
            })

        }
    }