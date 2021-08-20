using InfocusCase.Business.Abstract;
using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfocusCase.Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public void Add(Task task)
        {
            _taskDal.Add(task);
        }

        public Task CheckExist(int id)
        {
            return _taskDal.CheckExistPeople(id);
        }

        public List<Task> GetAll()
        {
            return _taskDal.GetAll();
        }

        public Task GetById(int id)
        {
            return _taskDal.GetById(id);
        }

        public void Update(Task task)
        {
            _taskDal.Update(task);
        }
    }
}
