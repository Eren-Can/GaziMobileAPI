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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public IDataResult<List<Slider>> GetAll()
        {
            var result = _sliderDal.GetAll();
            return new SuccessDataResult<List<Slider>>(result);
        }

        public IDataResult<Slider> GetById(int sliderId)
        {
            var result = _sliderDal.Get(a => a.Id == sliderId);
            return new SuccessDataResult<Slider>(result);
        }
    }
}
