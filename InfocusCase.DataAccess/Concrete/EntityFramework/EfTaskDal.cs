using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal : EfEntityRepositoryBase<InfocusCase.Entity.Concrete.Task, InfocusCaseDbContext>, ITaskDal
    {
        public Task CheckExistPeople(int id)
        {
            using (var context = new InfocusCaseDbContext())
            {
                return context.Tasks
                    .Where(i => i.Id == id)
                    .Include(i => i.PersonTasks)
                    .ThenInclude(i => i.Person)
                    .FirstOrDefault();
            }
        }
    }
}
