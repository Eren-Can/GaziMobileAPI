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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public IDataResult<List<Message>> GetAll()
        {
            var result = _messageDal.GetAll();
            return new SuccessDataResult<List<Message>>(result);
        }

        public IDataResult<Message> GetById(int messageId)
        {
            var result = _messageDal.Get(a => a.Id == messageId);
            return new SuccessDataResult<Message>(result);
        }
    }
}
