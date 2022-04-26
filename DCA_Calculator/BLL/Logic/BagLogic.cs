using BLL.Interfaces;
using DAL.interfaces;
using DCA_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Logic
{
    public class BagLogic : IBagLogic
    {
        private IBagRepository bagRepository;

        public BagLogic(IBagRepository bagRepository)
        {
            this.bagRepository = bagRepository;
        }

        public void Create(DCABag entity)
        {
            this.bagRepository.Create(entity);
        }

        public bool Delete(string uid)
        {
            return this.bagRepository.Delete(uid);
        }

        public ICollection<DCABag> GetAll()
        {
            return this.bagRepository.GetAll().ToList();
        }

        public DCABag GetOne(string uid)
        {
            return this.bagRepository.GetOne(uid);
        }

        public bool Update(string uid, string name)
        {
            return this.bagRepository.Update(uid, name);
        }

        public bool Update(string uid, DCABag entity)
        {
            return this.bagRepository.Update(uid, entity);
        }

        public bool DeletePortfolioFromBag(string bagId)
        {
            var bag = this.bagRepository.GetOne(bagId);
            if (bag != null)
            {
                bag.PortfolioId = null;
                return this.Update(bagId, bag);
            }

            return false;
        }
    }
}
