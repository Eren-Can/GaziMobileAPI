using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UnitManager : IUnitService
    {
        IUnitDal _unitDal;
        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }

        public IDataResult<List<Unit>> GetAll()
        {
            var result = _unitDal.GetAll();
            return new SuccessDataResult<List<Unit>>(result);
        }

        public IDataResult<Unit> GetById(int unitId)
        {
            var result = _unitDal.Get(a => a.Id == unitId);
            return new SuccessDataResult<Unit>(result);
        }
    }
}
