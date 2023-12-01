using MVCAgenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCAgenda.Controllers
{
    public class CompromissoController : Controller
    {
        public IActionResult Index()
        {
            return View(Dados.Db.compromissos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> Contatos = new List<SelectListItem>();
            Contatos = MVCAgenda.Dados.Db.contatos.Select(c => new SelectListItem() 
            { Text = c.Email, Value = c.Id.ToString() }).ToList();
            ViewBag.Contatos = Contatos;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Compromisso compromisso)
        {
            compromisso.Id = Dados.Db.compromissos.Max(c => c.Id) + 1;
            Contato ct = Dados.Db.contatos.FirstOrDefault(c => c.Id == compromisso.Contato.Id);
            compromisso.Contato = ct;
            Dados.Db.compromissos.Add(compromisso);
            return RedirectToAction("Index");
        }
    }
}
