using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ViewComponents
{
    public class ProductComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<ProductModel> products, bool whitebg = true)
        {
            if (whitebg)
                return View("WhiteBackground", products);

            return View("BlueBackground", products);
        }
    }
}
