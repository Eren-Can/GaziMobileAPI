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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IDataResult<List<Contact>> GetAll()
        {
            var result = _contactDal.GetAll();
            return new SuccessDataResult<List<Contact>>(result);
        }

        public IDataResult<Contact> GetById(int contactId)
        {
            var result = _contactDal.Get(a => a.Id == contactId);
            return new SuccessDataResult<Contact>(result);
        }
    }
}
