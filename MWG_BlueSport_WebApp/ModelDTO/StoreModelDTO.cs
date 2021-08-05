using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class StoreModelDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string address { get; set; }
        public string webAddress { get; set; }
        public string operatingTime { get; set; }
        public long phoneNumber { get; set; }
        public List<string> promotion { get; set; }
        public List<string> images { get; set; }
    }

    public static class StoreModelDTOExt
    {
        public static StoreModel ToStoreModel(this StoreModelDTO storeModelDTO)
        {
            return new StoreModel()
            {
                name = storeModelDTO.name,
                slug = storeModelDTO.slug,
                address = storeModelDTO.GetAddress(),
                operatingTime = storeModelDTO.operatingTime,
                phoneNumber = storeModelDTO.phoneNumber,
                promotion = storeModelDTO.promotion,
                images = storeModelDTO.images
            };
        }
        
        public static string GetAddress(this StoreModelDTO storeModelDTO)
        {
            return string.IsNullOrEmpty(storeModelDTO.webAddress) ? storeModelDTO.address : storeModelDTO.webAddress;
        }    
    }    
}
