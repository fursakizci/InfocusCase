using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Abstract
{
    public interface IPersonTaskService
    {
        void Add(PersonTask personTask);
        bool CheckAssignTaskToPerson(int personId, int taskId);
        PersonTask GetById(int id);
        void Delete(PersonTask personTask);
        PersonTask GetPersonTaskById(int personId, int taskId);
    }
}
