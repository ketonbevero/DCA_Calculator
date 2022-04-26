using DCA_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPortfolioLogic : ILogic<Portfolio>
    {
        bool Update(string uid, bool state);

        bool Update(string uid, string name);
    }
}
