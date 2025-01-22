using Imperiya.DataAccess.Abstract;
using Imperiya.DataAccess.Concrete;
using Imperiya.DataAccess.Repository;
using Imperiya.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperiya.DataAccess.EntityFramework
{
    public class EfPicsDal : GenericRepository<Pics>, IPicsDal
    {
        public EfPicsDal(Context context) : base(context)
        {
        }
    }
}
