using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Abstract
{
    public interface IPersonService
    {
        void Add(Person person);
        Person GetById(int id);
        List<Person> GetAll();
        Person GetAddress(int id);
        Person PersonTaskList(int id);
    }
}
