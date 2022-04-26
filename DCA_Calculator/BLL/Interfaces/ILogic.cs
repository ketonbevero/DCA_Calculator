using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILogic<T> where T : class
    {
        void Create(T entity);

        ICollection<T> GetAll();

        T GetOne(string uid);

        bool Delete(string uid);

        bool Update(string uid, T entity);
    }
}
