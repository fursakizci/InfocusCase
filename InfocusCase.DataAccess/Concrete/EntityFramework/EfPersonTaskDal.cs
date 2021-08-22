using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class EfPersonTaskDal : EfEntityRepositoryBase<PersonTask, InfocusCaseDbContext>, IPersonTaskDal
    {
        public bool CheckAssignTaskToPerson(int personId,int taskId)
        {
            using (var context = new InfocusCaseDbContext())
            {
                return context.Set<PersonTask>()
                    .Include(i => i.Person.Id == personId)
                    .Include(i => i.Task.Id == taskId)
                    .Any();
            }
        }

        public PersonTask GetPersonTaskById(int personId , int taskId)
        {
            using (var context = new InfocusCaseDbContext())
            {
                return context.PersonTasks
                    .Where(i => i.PersonId == personId && i.TaskId == taskId).FirstOrDefault();
            }
        }
    }
}
