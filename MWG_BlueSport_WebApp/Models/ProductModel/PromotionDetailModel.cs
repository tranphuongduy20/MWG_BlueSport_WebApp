using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG_BlueSport_WebApp.Models
{
    public class PromotionDetailModel
    {
        public string promotionInfo { get; set; }
        public bool isOnlinePromotion { get; set; }
        public bool isMore { get; set; }
    }
    public static class PromotionDetailModelExt
    {
        public static bool IsOnlinePromotion(this PromotionDetailModel promotionDetailModel)
        {
            return promotionDetailModel.isOnlinePromotion;
        }
        public static bool IsOMore(this PromotionDetailModel promotionDetailModel)
        {
            return promotionDetailModel.isMore;
        }
    }
}
