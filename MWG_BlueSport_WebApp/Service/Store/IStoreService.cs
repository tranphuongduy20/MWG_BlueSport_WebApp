﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;

namespace MWG_BlueSport_WebApp.Service.Store
{
    public interface IStoreService
    {
        public List<StoreModel> GetAll();
    }
}
