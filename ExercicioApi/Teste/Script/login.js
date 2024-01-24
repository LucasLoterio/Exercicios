function logar(){
    fetch(`http://localhost:5063/api/Users`, options)
    .then(data => {
        if (!data.ok) {
          throw Error(data.status);
         }
         return data.json();
        }).then(update => {
        console.log(update);
        })
}
