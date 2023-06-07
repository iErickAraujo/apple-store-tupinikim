using Microsoft.AspNetCore.Mvc;

namespace AppleStoreTupinikim.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Produto()
        {
            return View();
        }
    }
}
