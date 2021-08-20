using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using InfocusCase.Entity.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class EfPersonAddressDal : EfEntityRepositoryBase<PersonAddress, InfocusCaseDbContext>, IPersonAddressDal
    {
        //public CityDto GetCity(int id)
        //{
        //    using (var context = new InfocusCaseDbContext())
        //    {
        //        var result = (from pa in context.PersonAddresses
        //                     join c in context.Cities on pa.City.Id equals c.Id
        //                     where pa.Person.Id = id
        //                     select new CityDto
        //                     {
        //                         CityName = c.CityName
        //                     })                                   ;
        //        return result;
        //    }
        //}
    }
}
