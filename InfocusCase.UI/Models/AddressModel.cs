using System;
using System.Linq;
using System.Threading.Tasks;

namespace InfocusCase.UI.Models
{
    public class AddressModel
    {
        public string AddressType { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CitiesDrop { get; set; }
        public int DistrictsDrop { get; set; }
        public int PersonalId { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }

    }
}
