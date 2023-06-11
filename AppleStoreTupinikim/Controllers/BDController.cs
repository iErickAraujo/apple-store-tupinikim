using Microsoft.AspNetCore.Mvc;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Newtonsoft.Json;

using AppleStoreTupinikim.Models;

namespace AppleStoreTupinikim.Controllers
{
    public class BDController : Controller
    {
        IFirebaseClient cliente;
        
        public BDController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "qj6UFKzbgzouzi7c6ErsPSFfANZ1M8s6ZEOHxpZS",
                BasePath = "https://crudprodutos785-default-rtdb.firebaseio.com/",
            };

            cliente = new FirebaseClient(config);

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

            SetResponse response = cliente.Set("Produtos/"+idGerador, oProduto);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return View();
            }
            else { return View(); }
                
        }
    }
}
