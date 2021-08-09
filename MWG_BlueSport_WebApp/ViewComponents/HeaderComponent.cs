using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport_WebApp.Services.Category;
using MWG_BlueSport_WebApp.Models;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG_BlueSport_WebApp.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public HeaderComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<CategoryModel> models = await _categoryService.GetAll();
            return View(models);
        }
    }
}
