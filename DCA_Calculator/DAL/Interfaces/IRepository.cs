using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        T GetOne(string uid);

        IQueryable<T> GetAll();

        bool Delete(string uid);

        void Create(T entity);

        bool Update(string uid, T entity);
    }
}
