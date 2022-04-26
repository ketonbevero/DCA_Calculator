using DAL.interfaces;
using DCA_Calculator.Data;
using DCA_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TransactionRepository : BRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public override Transaction GetOne(string uid)
        {
            return this.ctx.Set<Transaction>().Find(uid);
        }
    }
}
