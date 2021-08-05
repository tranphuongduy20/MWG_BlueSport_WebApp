using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG_BlueSport_WebApp.Models
{
    public class StoreDetailViewModel : BaseViewModel
    {
        public StoreModel _store { get; set; }
        public List<StoreModel> _grandOpeningStore { get; set; }
    }
}
