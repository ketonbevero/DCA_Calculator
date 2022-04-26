using DCA_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITransactionLogic : ILogic<Transaction>
    {
        bool DeleteSelectedBagTransactions(string bagId);
    }
}
