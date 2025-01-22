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
    public class HeaderManager : IHeaderService
    {
        private readonly IHeaderDal _headerDal;

        public HeaderManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public async Task<List<Header>> TGetAllAsync()
        {
           return await _headerDal.GetAllAsync();
        }
    }
}
