using Microsoft.AspNetCore.Mvc;

namespace Projeto1Asp.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Produto()
        {
            return View();
        }
    }
}
