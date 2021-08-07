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
        private readonly ICategoryService _categoryService;

        public ProductDetailController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        // GET
        [Route("san-pham/{slug}")]
        public IActionResult Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            viewModel._productModel = _productService.GetBySlug(slug);
            viewModel._relatedProducts = _productService.GetAll();
            viewModel._categories = _categoryService.GetAll();
            return View(viewModel);
        }
    }
}
