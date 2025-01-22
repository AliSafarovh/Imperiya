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
    public class PicsManager : IPicsService
    {
        private readonly IPicsDal _picsDal;

        public PicsManager(IPicsDal picsDal)
        {
            _picsDal = picsDal;
        }

        public async Task<List<Pics>> TGetAllAsync()
        {
            return await _picsDal.GetAllAsync();
        }
    }
}
