using EntityFramework.AcessoDados;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _repository;

        public HomeController(IProdutoRepository repository)
        {
           this._repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.ListarProdutos());
        }

        public string Obter()
        {
            return "Teste 2";
        }
    }
}