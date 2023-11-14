using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorRepository _colorRepository;

        public ColorManager(IColorRepository colorDal)
        {
            _colorRepository = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorRepository.Add(color);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color color)
        {
            _colorRepository.Delete(color);
            return new SuccessResult(Messages.Deleted);
        }

        public List<Color> GetAll()
        {
            return new List<Color>(_colorRepository.GetList());
        }

        public IResult Update(Color color)
        {

            _colorRepository.Update(color);
            return new SuccessResult(Messages.Updated);
        }
    }
}
