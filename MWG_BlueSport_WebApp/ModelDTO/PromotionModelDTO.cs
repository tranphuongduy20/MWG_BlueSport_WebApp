using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class PromotionModelDTO
    {
        public string promotionName { get; set; }
        public List<PromotionDetailDTO> promotionList { get; set; }
    }
    public static class PromotionModelDTOExt
    {
        public static PromotionModel ToPromotionModel(this PromotionModelDTO promotionModelDto)
        {
            PromotionModel result = new PromotionModel();
            if (promotionModelDto != null)
            {

                result.promotionName = promotionModelDto.promotionName;

                result.promotionList = new List<PromotionDetailModel>();

                foreach (var item in promotionModelDto.promotionList)
                {
                    result.promotionList.Add(item.ToPromotionDetailModel());
                }
            }


            return result;
        }
    }
}
