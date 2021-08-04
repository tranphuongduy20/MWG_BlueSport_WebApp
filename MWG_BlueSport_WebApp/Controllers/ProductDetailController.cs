using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.Service.Product;

namespace MWG_BlueSport_WebApp.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IProductService _productService;

        public ProductDetailController(IProductService productService)
        {
            _productService = productService;
        }
        // GET
        [Route("san-pham/{slug}")]
        public IActionResult Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            viewModel._productModel = _productService.GetBySlug(slug);
            viewModel._relatedProducts = _productService.GetAll();

            return View(viewModel);
        }
    }
}
