using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfocusCase.UI.Models
{
    public class CityModel
    {
        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}
