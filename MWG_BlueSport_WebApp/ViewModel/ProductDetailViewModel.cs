using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG_BlueSport_WebApp.Models
{
    public class ProductDetailViewModel
    {
        public ProductModel _productModel { get; set; }
        public List<ProductModel> _relatedProducts { get; set; }
    }
}
