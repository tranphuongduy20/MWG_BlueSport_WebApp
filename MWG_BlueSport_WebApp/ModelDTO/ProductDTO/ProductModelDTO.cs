using MWG_BlueSport_WebApp.Models;
using System.Collections.Generic;
using System.Globalization;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class ProductModelDTO
    {
        public string id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public float priceCurrent { get; set; }
        public float priceOld { get; set; }
        public float saleOff { get; set; }
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
                priceCurrent = productModelDTO.priceCurrent.ToCurrency(),
                priceOld = productModelDTO.priceOld.ToCurrency(),
                saleOff = productModelDTO.saleOff.ToPercent(),
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
        public static string ToCurrency(this float price)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return price.ToString("#,###", cul.NumberFormat) + "₫";
        }

        public static string ToPercent(this float saleOff)
        {
            return '-' + (saleOff * 100).ToString() + '%';
        }
    }    
}
