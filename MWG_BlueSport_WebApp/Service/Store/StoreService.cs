using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Service.Client;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.ModelDTO;
using RestSharp;

namespace MWG_BlueSport_WebApp.Service.Store
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
        public List<StoreModel> GetAll()
        {
            #region Get Data DTO => API
            var response = _clientService.Get(_apiName);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StoreModelDTO>>(response.Content);
            #endregion

            List<StoreModel> storeModels = new List<StoreModel>();
            foreach (var item in dataDto)
            {
                storeModels.Add(item.ToStoreModel());
            }

            return storeModels;
        }
    }
}
