using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.ModelDTO
{
    public class CategoryModelDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public string parentId { get; set; }
    }
    public static class CategoryModelDTOExt
    {
        public static CategoryModel ToCategoryModel(this CategoryModelDTO catelogy)
        {
            return new CategoryModel()
            {
                id = catelogy.id,
                name = catelogy.name,
                level = catelogy.level,
            };
        }
    }
}
