using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.DataAccess.Abstract
{
    public interface IPersonDal:IEntityRepository<Person>
    {
        Person GetAddress(int id);
        Person PersonTaskList(int id);
    }
}
