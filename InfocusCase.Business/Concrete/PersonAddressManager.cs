using InfocusCase.Business.Abstract;
using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using InfocusCase.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Concrete
{
    public class PersonAddressManager : IPersonAddressService
    {
        private IPersonAddressDal _personAddressDal;

        public PersonAddressManager(IPersonAddressDal personAddressDal)
        {
            _personAddressDal = personAddressDal;
        }

        public void Add(PersonAddress personAddress)
        {
            _personAddressDal.Add(personAddress);
        }
    }
}
