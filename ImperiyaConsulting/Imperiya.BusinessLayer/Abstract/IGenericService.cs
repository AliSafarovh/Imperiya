using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperiya.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<List<T>> TGetAllAsync();
    }
}
