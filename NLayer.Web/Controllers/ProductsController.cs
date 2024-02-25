using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers
{
    //private readonly IProductService _services;
    public class ProductsController : Controller
    {
        private readonly IProductService _services;
        
        public async Task<IActionResult> Index()
        {
            return View( await _services.GetProductsWithCategory());
        }
    }
}
