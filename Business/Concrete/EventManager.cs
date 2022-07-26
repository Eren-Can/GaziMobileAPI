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
    public class EventManager : IEventService
    {
        IEventDal _eventDal;
        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        public IDataResult<List<Event>> GetAll()
        {
            var result = _eventDal.GetAll();
            return new SuccessDataResult<List<Event>>(result);
        }

        public IDataResult<Event> GetById(int eventId)
        {
            var result = _eventDal.Get(a => a.Id == eventId);
            return new SuccessDataResult<Event>(result);
        }
    }
}
