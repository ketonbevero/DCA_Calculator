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
    public class PortfolioRepository : BRepository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public override Portfolio GetOne(string uid)
        {
            return this.ctx.Set<Portfolio>().Find(uid);
        }

        public bool Update(string uid, bool state)
        {
            var portfolio = this.GetOne(uid);

            if (portfolio != null)
            {
                portfolio.Open = false;
                this.ctx.SaveChanges();

                return true;
            }

            return false;
        }

        public bool Update(string uid, string name)
        {
            var portfolio = this.GetOne(uid);

            if (portfolio != null)
            {
                portfolio.Name = name;
                this.ctx.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
