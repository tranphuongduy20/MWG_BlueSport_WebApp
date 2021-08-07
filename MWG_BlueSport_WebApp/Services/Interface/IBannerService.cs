using System.Collections.Generic;
using MWG_BlueSport_WebApp.ModelDTO;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.Services.Interface
{
    public interface IBannerService
    {
        public List<BannerModel> GetAll();
    }
}
