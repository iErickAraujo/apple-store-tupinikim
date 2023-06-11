using Microsoft.AspNetCore.Mvc;

namespace AppleStoreTupinikim.Controllers
{
    public class ListadeProdutosController : Controller
    {
        public IActionResult ListaDeProdutos()
        {
            return View();
        }
    }
}
