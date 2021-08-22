using InfocusCase.Business.Abstract;
using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Concrete
{
    public class PersonTaskManager : IPersonTaskService
    {
        private IPersonTaskDal _personTaskDal;
        public PersonTaskManager(IPersonTaskDal personTaskDal)
        {
            _personTaskDal = personTaskDal;
        }
        public void Add(PersonTask personTask)
        {
            _personTaskDal.Add(personTask);
        }

        public bool CheckAssignTaskToPerson(int personId, int taskId)
        {
            return _personTaskDal.CheckAssignTaskToPerson(personId,taskId);
        }

        public void Delete(PersonTask personTask)
        {
            _personTaskDal.Delete(personTask);
        }

        public PersonTask GetById(int id)
        {
            return _personTaskDal.GetById(id);
        }

        public PersonTask GetPersonTaskById(int personId, int taskId)
        {
            return _personTaskDal.GetPersonTaskById(personId,taskId);
        }
    }
}
