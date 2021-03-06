using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Services.Interface;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.ModelDTO;
using RestSharp;

namespace MWG_BlueSport_WebApp.Services
{
    public class StoreService : IStoreService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public StoreService(IClientService clientService)
        {
            _clientService = clientService;

            _apiName = "store";
        }
        public async Task<List<StoreModel>> GetAll()
        {
            #region Get Data DTO => API
            var response = await _clientService.Get(_apiName);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StoreModelDTO>>(response.Content);
            #endregion

            List<StoreModel> storeModels = new List<StoreModel>();
            foreach (var item in dataDto)
            {
                storeModels.Add(item.ToStoreModel());
            }

            return storeModels;
        }
        public async Task<StoreModel> GetBySlug(string slug)
        {
            var response = await _clientService.Get(_apiName + "/" + slug);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<StoreModelDTO>(response.Content);

            return dataDto.ToStoreModel();
        }
    }
}
