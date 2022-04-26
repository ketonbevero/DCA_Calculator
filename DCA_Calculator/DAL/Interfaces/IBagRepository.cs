using DCA_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IBagRepository : IRepository<DCABag>
    {
        bool Update(string uid, string name);
    }
}
