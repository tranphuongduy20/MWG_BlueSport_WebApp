using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.Services.Interface;
using MWG_BlueSport_WebApp.Services.Category;

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
        public async Task<IActionResult> Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            viewModel._productModel = await _productService.GetBySlug(slug);
            viewModel._relatedProducts = await _productService.GetAll();
            return View(viewModel);
        }
    }
}
