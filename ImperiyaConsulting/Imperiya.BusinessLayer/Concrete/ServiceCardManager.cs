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
    public class ServiceCardManager : IServiceCardService
    {
        private readonly IServiceCardDal _serviceDal;

        public ServiceCardManager(IServiceCardDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public async Task<List<ServiceCard>> TGetAllAsync()
        {
           return await _serviceDal.GetAllAsync();
        }
    }
}
