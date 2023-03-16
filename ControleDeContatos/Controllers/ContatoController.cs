using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Criar() => View();

        public IActionResult Editar() => View();

        public IActionResult ApagarConfirmacao() => View();

        public IActionResult Apagar() => View();
    }

}
