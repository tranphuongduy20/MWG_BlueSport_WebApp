using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace MWG_BlueSport_WebApp.Services.Interface
{
    public interface IClientService
    {
        public IRestResponse Get(string path);
    }
}
