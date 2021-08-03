﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.ModelDTO;
using MWG_BlueSport_WebApp.Service.Client;
using RestSharp;

namespace MWG_BlueSport_WebApp.Service.Banner
{
    public class BannerService : IBannerService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public BannerService(IClientService clientService)
        {
            _clientService = clientService;

            _apiName = "banner";
        }
        public List<BannerModel> GetAll()
        {
            #region Get Data DTO => API

            var response = _clientService.Get(_apiName);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BannerModelDTO>>(response.Content);
            #endregion

            List<BannerModel> bannerModels = new List<BannerModel>();

            //mapping
            foreach (var item in dataDto)
            {
                bannerModels.Add(item.ToBannerModel());
            }

            return bannerModels;
        }
    }
}
