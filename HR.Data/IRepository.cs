using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Data
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> FindAll(bool disableProxies = false);
        IQueryable<T> Table { get; }
    }
}
