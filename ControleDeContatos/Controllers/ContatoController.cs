using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio) { 
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index() => View();

        public IActionResult Criar() => View();

        public IActionResult Editar() => View();

        public IActionResult ApagarConfirmacao() => View();

        public IActionResult Apagar() => View();

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        } 
    }

}
