using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetById(int id);
    }
}
