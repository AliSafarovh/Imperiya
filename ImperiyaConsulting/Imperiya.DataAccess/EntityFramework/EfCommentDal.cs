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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(Context context) : base(context)
        {
        }
    }
}
