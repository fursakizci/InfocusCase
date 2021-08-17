using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Abstract
{
    public interface IDistrictService
    {
        List<District> GetAll(int cityId);
        District GetById(int id);
    }
}
