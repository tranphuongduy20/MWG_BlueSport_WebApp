using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;
using System.Drawing;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class ProductModelDTO
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
        public List<SizeProductDTO> sizes { get; set; }
        public PromotionModelDTO promotion { get; set; }
    }

    public static class ProducModelDTOExt
    {
        public static ProductModel ToProductModel(this ProductModelDTO productModelDTO)
        {
            var result = new ProductModel()
            {
                id = productModelDTO.id,
                name = productModelDTO.name,
                image = productModelDTO.image,
                priceCurrent = productModelDTO.priceCurrent,
                priceOld = productModelDTO.priceOld,
                saleOff = productModelDTO.saleOff,
                brandName = productModelDTO.brandName,
                brandInfo = productModelDTO.brandInfo,
                description = productModelDTO.description,
                imageBrand = productModelDTO.imageBrand,
                productDetail = productModelDTO.productDetail,
                slug = productModelDTO.slug,
                promotion = productModelDTO.promotion.ToPromotionModel()
            };

            result.sizes = new List<SizeProductModel>();
            if (productModelDTO.sizes != null)
            {
                foreach (var item in productModelDTO.sizes)
                {
                    result.sizes.Add(item.ToSizeModel());
                }
            }

            return result;
        }    
    }    
}
