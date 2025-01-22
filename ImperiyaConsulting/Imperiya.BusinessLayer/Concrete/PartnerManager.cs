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
    public class PartnerManager : IPartnerService
    {
        private readonly IPartnerDal _partnerDal;

        public PartnerManager(IPartnerDal partnerDal)
        {
            _partnerDal = partnerDal;
        }

        public async Task<List<Partner>> TGetAllAsync()
        {
           return await _partnerDal.GetAllAsync();
        }
    }
}
