using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.ModelDTO;
using MWG_BlueSport_WebApp.Services.Interface;
using RestSharp;

namespace MWG_BlueSport_WebApp.Services
{
    public class ProductService : IProductService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public ProductService(IClientService clientService)
        {
            _clientService = clientService;
            _apiName = "product";
        }

        public List<ProductModel> GetAll()
        {
            #region Get Data DTO => API

            var response = _clientService.Get(_apiName);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductModelDTO>>(response.Content);
            #endregion

            List<ProductModel> productModels = new List<ProductModel>();

            foreach (var item in dataDto)
            {
                productModels.Add(item.ToProductModel());
            }

            return productModels;
        }
        public ProductModel Get(string id)
        {
            var response = _clientService.Get(_apiName + "/" + id);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductModelDTO>(response.Content);


            return dataDto.ToProductModel();
        }

        public ProductModel GetBySlug(string slug)
        {
            var response = _clientService.Get(_apiName + "/" + slug);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductModelDTO>(response.Content);


            return dataDto.ToProductModel();
        }
    }
}
