using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class SizeProductDTO
    {
        public string name { get; set; }
        public int quantity { get; set; }
    }
    public static class SizeProductDTOExt
    {
        public static bool IsDisable(this SizeProductDTO sizeProductDto)
        {
            return sizeProductDto.quantity == 0;
        }
    
        public static SizeProductModel ToSizeModel(this SizeProductDTO sizeProductDto)
        {
            return new SizeProductModel()
            {
                name = sizeProductDto.name,
                quantity = sizeProductDto.quantity,
            };
        }
    }
}
