using DCA_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBagLogic : ILogic<DCABag>
    {
        public bool Update(string uid, string name);

        bool DeletePortfolioFromBag(string bagId);
    }
}
