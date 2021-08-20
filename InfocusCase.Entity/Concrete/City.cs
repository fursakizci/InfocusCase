using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Entity.Concrete
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public List<PersonAddress> PersonAddresses { get; set; }
        public List<District> Districts { get; set; }

    }
}
