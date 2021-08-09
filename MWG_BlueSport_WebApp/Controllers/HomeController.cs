using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MWG_BlueSport_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Services.Interface;
using MWG_BlueSport_WebApp.Services.Category;

namespace MWG_BlueSport_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBannerService _bannerService;
        private readonly IStoreService _storeService;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IBannerService bannerService, IStoreService storeService, IProductService productService)
        {
            _logger = logger;
            _bannerService = bannerService;
            _productService = productService;
            _storeService = storeService;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.bannerModels = await _bannerService.GetAll();
            homeViewModel.storeModels = await _storeService.GetAll();
            homeViewModel.productModels = await _productService.GetAll();
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
