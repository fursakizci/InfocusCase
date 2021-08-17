using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InfocusCase.Entity.Concrete
{
    public class PersonTask
    {
        [Key]
        public int Id { get; set; }
        public Person Person { get; set; }
        public Task Task { get; set; }
        public string TaskStatus { get; set; }
    }
}
