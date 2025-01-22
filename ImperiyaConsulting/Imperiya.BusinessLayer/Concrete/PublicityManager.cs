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
    public class PublicityManager : IPublicityService
    {
        private readonly IPublicityDal _publicityDal;

        public PublicityManager(IPublicityDal publicityDal)
        {
            _publicityDal = publicityDal;
        }

        public async Task<List<Publicity>> TGetAllAsync()
        {
           return await _publicityDal.GetAllAsync();
        }
    }
}
