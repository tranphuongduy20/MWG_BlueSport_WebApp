using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.Models
{
    public class SizeProductModel
    {
        public string name { get; set; }
        public int quantity { get; set; }
    }
    public static class SizeProductModelExt
    {
        public static bool IsDisable(this SizeProductModel sizeProductDto)
        {
            return sizeProductDto.quantity == 0;
        }
    }
}
