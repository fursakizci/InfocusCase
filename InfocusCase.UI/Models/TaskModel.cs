using InfocusCase.Entity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = InfocusCase.Entity.Concrete.Task;

namespace InfocusCase.UI.Models
{
    public class TaskModel
    {
        public IEnumerable<SelectListItem> Status { get; set; }
        public List<Person> People { get; set; }
        public Task Task { get; set; }
    }
}
