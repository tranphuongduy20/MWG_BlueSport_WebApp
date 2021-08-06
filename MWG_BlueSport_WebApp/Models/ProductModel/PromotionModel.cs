using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.ModelDTO;

namespace MWG_BlueSport_WebApp.Models
{
    public class PromotionModel
    {
        public string promotionName { get; set; }
        public List<PromotionDetailModel> promotionList { get; set; }
    }
}
