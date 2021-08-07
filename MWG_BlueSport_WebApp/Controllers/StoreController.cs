using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.Services.Interface;
using MWG_BlueSport_WebApp.Services.Category;

namespace MWG_BlueSport_WebApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;

        private readonly ICategoryService _categoryService;

        public StoreController(IStoreService storeService, ICategoryService categoryService)
        {
            _storeService = storeService;
            _categoryService = categoryService;
        }
        // GET
        [Route("cua-hang/{slug}")]
        public IActionResult Detail(string slug)
        {
            var viewModel = new StoreDetailViewModel();

            viewModel._categories = _categoryService.GetAll();

            viewModel._store = _storeService.GetBySlug(slug);

            viewModel._grandOpeningStore = _storeService.GetAll();

            return View(viewModel);
        }
    }
}
