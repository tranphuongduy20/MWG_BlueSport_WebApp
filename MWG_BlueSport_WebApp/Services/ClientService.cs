﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using System.IO;
using Microsoft.Extensions.Configuration;
using MWG_BlueSport_WebApp.Services.Interface;

namespace MWG_BlueSport_WebApp.Services
{
    public class ClientService : IClientService
    {
        private string _url;
        private string _basePath;

        public ClientService()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var url = configuration.GetSection("BaseUrl").Value;
            var basePath = configuration.GetSection("BasePath").Value;

            _url = url;
            _basePath = basePath;
        }

        public async Task<IRestResponse> Get(string path)
        {
            var client = new RestClient(_url + _basePath + path);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);

            return response;
        }
    }
}
