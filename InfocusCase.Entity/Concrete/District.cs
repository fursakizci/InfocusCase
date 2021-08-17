using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InfocusCase.Entity.Concrete
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public City City { get; set; }
    }
}
