using Imperiya.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imperiya.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        public GenericRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await _context.Set<T>().ToListAsync();
        }
    }
}
