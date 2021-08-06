using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.ModelDTO;

namespace MWG_BlueSport_WebApp.Models
{
    public class ProductModel
    {
        public string id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string priceCurrent { get; set; }
        public string priceOld { get; set; }
        public string saleOff { get; set; }
        public string brandName { get; set; }
        public string brandInfo { get; set; }
        public string description { get; set; }
        public string imageBrand { get; set; }
        public Dictionary<string, string>[] productDetail { get; set; }
        public List<SizeProductModel> sizes { get; set; }
        public PromotionModel promotion { get; set; }
    }
}
