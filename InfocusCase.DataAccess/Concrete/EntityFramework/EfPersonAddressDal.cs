using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class EfPersonAddressDal:EfEntityRepositoryBase<PersonAddress,InfocusCaseDbContext>,IPersonAddressDal
    {
    }
}
