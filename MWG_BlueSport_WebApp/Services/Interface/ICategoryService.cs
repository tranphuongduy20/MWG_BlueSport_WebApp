using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.ModelDTO;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.Services.Category
{
    public interface ICategoryService
    {
        public Task<List<CategoryModel>> GetAll();
    }
}
