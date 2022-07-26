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
    public class AnnouncementManager : IAnnouncementService
    {

        IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public IDataResult<List<Announcement>> GetAll()
        {
            var result = _announcementDal.GetAll();
            return new SuccessDataResult<List<Announcement>>(result);
        }

        public IDataResult<Announcement> GetById(int announcementId)
        {
            var result = _announcementDal.Get(a => a.Id == announcementId);
            return new SuccessDataResult<Announcement>(result);
        }
    }
}
