using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class ProductModelDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string priceCurrent { get; set; }
        public string priceOld { get; set; }
        public string saleOff { get; set; }
        public string brandName { get; set; }
        public string imageBrand { get; set; }
    }

    public static class ProducModelDTOExt
    {
        public static ProductModel ToProductModel(this ProductModelDTO productModelDTO)
        {
            return new ProductModel()
            {
                name = productModelDTO.name,
                image = productModelDTO.image,
                priceCurrent = productModelDTO.priceCurrent,
                priceOld = productModelDTO.priceOld,
                saleOff = productModelDTO.saleOff,
                brandName = productModelDTO.brandName,
                imageBrand = productModelDTO.imageBrand
            };
        }    
    }    
}
