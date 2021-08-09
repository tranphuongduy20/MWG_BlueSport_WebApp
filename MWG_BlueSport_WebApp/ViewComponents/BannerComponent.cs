using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ViewComponents
{
    public class BannerComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<BannerModel> banners)
        {
            return View(banners);
        }
    }
}
