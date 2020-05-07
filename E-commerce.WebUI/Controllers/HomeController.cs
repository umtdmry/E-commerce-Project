using E_commerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        // GET
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
    }
}