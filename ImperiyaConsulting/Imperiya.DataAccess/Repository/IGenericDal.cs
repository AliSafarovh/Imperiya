using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperiya.DataAccess.Repository
{
    public interface IGenericDal<T> where T : class
    {
        Task<List<T>> GetAllAsync();

    }
}
