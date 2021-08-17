using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InfocusCase.DataAccess.Abstract
{
    public interface ITaskDal:IEntityRepository<InfocusCase.Entity.Concrete.Task>
    {
    }
}
