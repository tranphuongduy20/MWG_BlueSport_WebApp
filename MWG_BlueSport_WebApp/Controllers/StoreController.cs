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

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        // GET
        [Route("cua-hang/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            var viewModel = new StoreDetailViewModel();
            viewModel._store = await _storeService.GetBySlug(slug);
            viewModel._grandOpeningStore = await _storeService.GetAll();
            return View(viewModel);
        }
    }
}
