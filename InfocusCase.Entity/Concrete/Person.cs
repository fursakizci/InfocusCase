using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InfocusCase.Entity.Concrete
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender{ get; set; }
        public List<PersonAddress> PersonAddresses { get; set; }
        public List<PersonTask> PersonTasks { get; set; }
    }
}
