using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, InfocusCaseDbContext>, IPersonDal
    {
      

        public Person GetAddress(int id)
        {
            using (var context = new InfocusCaseDbContext())
            {
                return context.People
                    .Where(i => i.Id == id)
                    .Include(i => i.PersonAddresses)
                    .ThenInclude(i => i.City)
                    .ThenInclude(i=>i.Districts)
                    .FirstOrDefault();
            }
        }

        public Person PersonTaskList(int id)
        {
            using (var context = new InfocusCaseDbContext())
            {
                return context.People
                    .Where(i => i.Id == id)
                    .Include(i => i.PersonTasks)
                    .ThenInclude(i=>i.Task)
                    .FirstOrDefault();
            }
        }
        public bool CheckTaskListForPerson(int personId, int taskId)
        {
            using (var context = new InfocusCaseDbContext())
            {
                var result = context.People
                    .Where(i => i.Id == personId)
                    .Include(i => i.PersonTasks)
                    .FirstOrDefault();

                return result.PersonTasks.Where(i => i.PersonId == personId && i.TaskId == taskId).Any();
                
            }
        }
    }
}
