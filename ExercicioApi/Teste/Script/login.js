async function Logar()
    {
        let resultado = document.querySelector("#resultados")
        let auxU = document.getElementById("user").value
        let auxS = document.getElementById("senha").value
        let obj = 
        {
            userName: auxU,
            password: auxS
        }
        if(auxU != "" && auxS != "")
        {
            fetch('http://localhost:5063/api/Users',
            {
                method: "POST",
                headers: {'Content-Type' : 'application/json'},
                body: JSON.stringify(obj)
            })
            .then(data => data.json())
            .then(resp => {
                localStorage.setItem('token', resp.token)
            })
        }
        if(localStorage.getItem("token") === null){
        resultado.innerHTML = "Login realizado com sucesso!"
    }
    }