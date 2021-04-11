using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubeGoldbergFunction.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> FindAll();
        T FindById(object id);
        T Create(T obj);
    }
}
