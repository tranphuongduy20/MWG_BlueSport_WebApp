using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG_BlueSport_WebApp.ViewComponents
{
    public class StoreComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<StoreModel> stores)
        {
            return View(stores);
        }
    }
}
