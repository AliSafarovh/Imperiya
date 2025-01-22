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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public async Task<List<Comment>> TGetAllAsync()
        {
            return await _commentDal.GetAllAsync();
        }
    }
}
