using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.ViewModels
{
    public class ReceiveProductViewModel
    {
        public string ShipToName { get; set; }
        public string ShipToPhone { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToStreet { get; set; }
        public string ShipToDistrict { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCountry { get; set; }
    }
}
