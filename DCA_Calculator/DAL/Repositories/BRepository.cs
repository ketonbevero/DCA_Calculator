using DCA_Calculator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class BRepository<T> : IRepository<T> where T : class
    {
        private protected ApplicationDbContext ctx;

        public BRepository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(T entity)
        {
            if (!this.ctx.Set<T>().Contains(entity))
            {
                this.ctx.Set<T>().Add(entity);
                this.ctx.SaveChanges();
            }
        }

        public bool Delete(string uid)
        {
            var entity = this.ctx.Set<T>().Find(uid);

            if (this.ctx.Set<T>().Contains(entity))
            {
                this.ctx.Set<T>().Remove(entity);
                this.ctx.SaveChanges();
                return true;
            }

            return false;
        }

        public IQueryable<T> GetAll()
        {
            return this.ctx.Set<T>();
        }

        public abstract T GetOne(string uid);

        public bool Update(string uid, T entity)
        {
            var entityToUpdate = this.ctx.Set<T>().Find(uid);

            if (entityToUpdate != null)
            {
                entityToUpdate = entity;
                this.ctx.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
