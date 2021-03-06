using InfocusCase.Business.Abstract;
using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public void Add(Person person)
        {
            _personDal.Add(person);
        }
        public Person GetAddress(int id)
        {
            return _personDal.GetAddress(id);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public Person GetById(int id)
        {
            return _personDal.GetById(id);
        }

        public Person PersonTaskList(int id)
        {
            return _personDal.PersonTaskList(id);
        }

        public bool CheckTaskListForPerson(int personId, int taskId)
        {
            return _personDal.CheckTaskListForPerson(personId,taskId);
        }
    }
}
