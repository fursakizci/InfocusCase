using InfocusCase.Business.Abstract;
using InfocusCase.DataAccess.Abstract;
using InfocusCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        private IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }
        public List<District> GetAll(int cityId)
        {
            return _districtDal.GetAll(p=>p.City.Id == cityId);
        }

        public District GetById(int id)
        {
            return _districtDal.GetById(id);
        }
    }
}
