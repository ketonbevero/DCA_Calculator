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
    public class BagRepository : BRepository<DCABag>, IBagRepository
    {
        public BagRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public override DCABag GetOne(string uid)
        {
            return this.ctx.Set<DCABag>().Find(uid);
        }

        public bool Update(string uid, string name)
        {
            var bag = this.GetOne(uid);

            if (bag != null)
            {
                bag.Name = name;
                this.ctx.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
