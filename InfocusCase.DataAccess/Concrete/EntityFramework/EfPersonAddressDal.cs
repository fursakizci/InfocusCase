using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class EfPersonAddressDal : EfEntityRepositoryBase<PersonAddress, InfocusCaseDbContext>, IPersonAddressDal
    {
        
    }
}
