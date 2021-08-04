using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG_BlueSport_WebApp.Models
{
    public class CategoryModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public List<CategoryModel> subCate { get; set; }
    }
}
