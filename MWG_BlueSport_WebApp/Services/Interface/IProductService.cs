using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.Services.Interface
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetAll();
        public Task<ProductModel> Get(string id);
        public Task<ProductModel> GetBySlug(string slug);
    }
}
