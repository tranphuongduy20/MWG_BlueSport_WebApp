﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MWG_BlueSport_WebApp.Models;
using MWG_BlueSport_WebApp.ModelDTO;
using MWG_BlueSport_WebApp.Services.Interface;

namespace MWG_BlueSport_WebApp.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public CategoryService(IClientService clientService)
        {
            _apiName = "category";
            _clientService = clientService;
        }
        public List<CategoryModel> GetAll()
        {
            var response = _clientService.Get(_apiName);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CategoryModelDTO>>(response.Content);

            var categoryModels = new List<CategoryModel>();

            if (dataDto != null)
            {
                var rootCate = dataDto.Where(x => x.level == 0).ToList();
                var subCate = dataDto.Where(x => x.level == 1).ToList();
                var lastCate = dataDto.Where(x => x.level == 2).ToList();

                foreach (var root in rootCate)
                {
                    var tempRoot = root.ToCategoryModel();

                    tempRoot.subCate = new List<CategoryModel>();

                    var subList = subCate.Where(x => x.parentId == tempRoot.id).ToList();

                    foreach (var sub in subList)
                    {
                        var tempSub = sub.ToCategoryModel();

                        var tempLast = lastCate.Where(x => x.parentId == sub.id).ToList();

                        tempSub.subCate = new List<CategoryModel>();

                        foreach (var item in tempLast)
                        {
                            tempSub.subCate.Add(item.ToCategoryModel());
                        }

                        tempRoot.subCate.Add(tempSub);

                    }

                    categoryModels.Add(tempRoot);

                }

            }
            return categoryModels;
        }
    }
}
