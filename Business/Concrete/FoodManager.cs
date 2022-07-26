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
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;
        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public IDataResult<List<Food>> GetAll()
        {
            var result = _foodDal.GetAll();
            return new SuccessDataResult<List<Food>>(result);
        }

        public IDataResult<Food> GetById(int foodId)
        {
            var result = _foodDal.Get(a => a.Id == foodId);
            return new SuccessDataResult<Food>(result);
        }
    }
}
