using Microsoft.AspNetCore.Mvc;
using MVCAgenda.Models;

namespace MVCAgenda.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {           
            return View(Dados.Db.contatos);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Contato contato)
        {
            contato.Id = Dados.Db.contatos.Count + 1;
            Dados.Db.contatos.Add(contato);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Models.Contato contato = Dados.Db.contatos.FirstOrDefault(ct => ct.Id == id); 
            return View(contato);
        }

        [HttpPost]
        public IActionResult Edit(Models.Contato contato)
        {
            Models.Contato cont = Dados.Db.contatos.FirstOrDefault(ct => ct.Id == contato.Id);
            cont.Nome = contato.Nome;
            cont.Email = contato.Email;
            cont.Fone= contato.Fone;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            Models.Contato contato = Dados.Db.contatos.FirstOrDefault(ct => ct.Id == id);
            return View(contato);
        }
        public IActionResult Delete(int? id)
        {
            Contato contato = Dados.Db.contatos.FirstOrDefault(contato => contato.Id == id);

            return View(contato);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            Contato contato = Dados.Db.contatos.FirstOrDefault(contato => contato.Id == id);

            if (contato != null)
            {
                Dados.Db.contatos.Remove(contato);
            }
            return RedirectToAction("Index");
        }

    }
}
