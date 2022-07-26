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
    public class ReportManager : IReportService
    {
        IReportDal _reportDal;
        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public IDataResult<List<Report>> GetAll()
        {
            var result = _reportDal.GetAll();
            return new SuccessDataResult<List<Report>>(result);
        }

        public IDataResult<Report> GetById(int reportId)
        {
            var result = _reportDal.Get(a => a.Id == reportId);
            return new SuccessDataResult<Report>(result);
        }
    }
}
