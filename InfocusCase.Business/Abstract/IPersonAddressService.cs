using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Abstract
{
    public interface IPersonAddressService
    {
        void Add(PersonAddress personAddress);
        List<PersonAddress> GetAll();
        PersonAddress GetById(int id);
    }
}
