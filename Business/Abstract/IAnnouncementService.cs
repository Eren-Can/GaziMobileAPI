using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnnouncementService
    {
        IDataResult<List<Announcement>> GetAll();
        IDataResult<Announcement> GetById(int Id);
    }
}
