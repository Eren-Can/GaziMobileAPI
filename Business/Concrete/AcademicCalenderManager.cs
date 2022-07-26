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
    public class AcademicCalenderManager : IAcademicCalenderService
    {
        IAcademicCalenderDal _academicCalenderDal;
        public AcademicCalenderManager(IAcademicCalenderDal academicCalenderDal)
        {
            _academicCalenderDal = academicCalenderDal;
        }

        public IDataResult<List<AcademicCalender>> GetAll()
        {
            var result = _academicCalenderDal.GetAll();
            return new SuccessDataResult<List<AcademicCalender>>(result);
        }

        public IDataResult<AcademicCalender> GetById(int academicCalenderId)
        {
            var result = _academicCalenderDal.Get(a => a.Id == academicCalenderId);
            return new SuccessDataResult<AcademicCalender>(result);
        }
    }
}
