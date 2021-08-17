using InfocusCase.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal:EfEntityRepositoryBase<InfocusCase.Entity.Concrete.Task,InfocusCaseDbContext>,ITaskDal
    {
    }
}
