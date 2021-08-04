using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG_BlueSport_WebApp.Models
{
    public class HomeViewModel : BaseViewModel
    {
        public List<BannerModel> bannerModels { get; set; }
        public List<StoreModel> storeModels { get; set; }
        public List<ProductModel> productModels { get; set; }
    }
}
