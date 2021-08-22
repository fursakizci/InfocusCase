using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.DataAccess.Abstract
{
    public interface IPersonTaskDal:IEntityRepository<PersonTask>
    {
        bool CheckAssignTaskToPerson(int personId, int taskId);
        PersonTask GetPersonTaskById(int personId, int taskId);
    }
}
