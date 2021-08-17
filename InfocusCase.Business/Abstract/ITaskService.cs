using System;
using System.Collections.Generic;
using System.Text;
using InfocusCase.Entity.Concrete;

namespace InfocusCase.Business.Abstract
{
    public interface ITaskService
    {
        void Add(Task task);
        List<Task> GetAll();
    }
}
