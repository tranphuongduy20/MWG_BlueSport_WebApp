using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.Services.Interface
{
    public interface IStoreService
    {
        public List<StoreModel> GetAll();
        public StoreModel GetBySlug(string slug);
    }
}
