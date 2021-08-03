using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class BannerModelDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pathImg { get; set; }
        public string altImg { get; set; }
        public string description { get; set; }
    }

    public static class BannerModelDTOExt
    {
        public static BannerModel ToBannerModel(this BannerModelDTO bannerModelDTO)
        {
            return new BannerModel()
            {
                pathImg = bannerModelDTO.pathImg,
                altImg = bannerModelDTO.altImg,
                description = bannerModelDTO.description
            };
        }    
    }
}
