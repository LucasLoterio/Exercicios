using CrudMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudMVC.Controllers
{
    public class ContatoController : Controller
    {
        private static List<Contato> contatos = new();
        public IActionResult Index()
        {
           // contatos.Add(new Contato { Id = 1, Name = "Jamal", Email = "Jamal@gmail.com", Fone = "4002-8922" });
            return View(contatos);
        }
        [HttpGet]
        public IActionResult Create()
        {
           
              return View();
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            contato.Id = contatos.Count + 1;
            contatos.Add(contato);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Contato ctts = contatos.FirstOrDefault(ct => ct.Id == id);
            return View(ctts);
        }

        [HttpPost]
        public IActionResult Edit(Contato ctts)
        {
            Contato ctt = contatos.FirstOrDefault(ct => ct.Id == ctts.Id);
            ctt.Name = ctts.Name;
            ctt.Email = ctts.Email;
            ctt.Fone = ctts.Fone;
            return RedirectToAction("Index");
        }


    }
}
