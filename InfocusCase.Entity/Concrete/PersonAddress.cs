using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InfocusCase.Entity.Concrete
{
    public class PersonAddress
    {
        [Key]
        public int Id { get; set; }
        public Person Person{ get; set; }
        public string AddressType { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public District District { get; set; }
        public string Address { get; set; }
        
    }
}
