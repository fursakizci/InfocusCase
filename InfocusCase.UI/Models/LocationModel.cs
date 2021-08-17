using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace InfocusCase.UI.Models
{
    public class LocationModel
    {
        public IEnumerable<SelectListItem> Cities { get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }
        public List<AddressModel> AddressModels { get; set; }
        public LocationModel()
        {
            AddressModels = new List<AddressModel>();
        }
    }
}
