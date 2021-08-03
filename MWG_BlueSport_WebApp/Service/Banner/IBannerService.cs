using System.Collections.Generic;
using MWG_BlueSport_WebApp.ModelDTO;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.Service.Banner
{
    public interface IBannerService
    {
        public List<BannerModel> GetAll();
    }
}
