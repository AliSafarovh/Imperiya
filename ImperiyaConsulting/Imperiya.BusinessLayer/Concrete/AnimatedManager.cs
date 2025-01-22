using Imperiya.BusinessLayer.Abstract;
using Imperiya.DataAccess.Abstract;
using Imperiya.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperiya.BusinessLayer.Concrete
{
    public class AnimatedManager : IAnimatedService
    {
        private readonly IAnimatedDal _animatedDal;

        public AnimatedManager(IAnimatedDal animatedDal)
        {
            _animatedDal = animatedDal;
        }

        public async Task<List<Animated>> TGetAllAsync()
        {
            return await _animatedDal.GetAllAsync();
        }
    }
}
