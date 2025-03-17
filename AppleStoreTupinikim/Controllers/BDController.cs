using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using AppleStoreTupinikim.Models;

namespace AppleStoreTupinikim.Controllers
{
    public class BDController : Controller
    {
        private readonly IFirebaseClient _cliente;

        public BDController(IConfiguration configuration)
        {
            var authSecret = configuration["Firebase:AuthSecret"];
            var basePath = configuration["Firebase:BasePath"];

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = authSecret,
                BasePath = basePath,
            };

            _cliente = new FirebaseClient(config);
        }

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(BdProdutos oProduto)
        {
            string idGerador = Guid.NewGuid().ToString("N");

            SetResponse response = _cliente.Set("Produtos/" + idGerador, oProduto);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
