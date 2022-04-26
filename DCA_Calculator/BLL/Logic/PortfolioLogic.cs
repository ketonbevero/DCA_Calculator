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
    public class PortfolioLogic : IPortfolioLogic
    {
        private IPortfolioRepository portfolioRepository;

        public PortfolioLogic(IPortfolioRepository portfolioRepository)
        {
            this.portfolioRepository = portfolioRepository;
        }

        public void Create(Portfolio entity)
        {
            this.portfolioRepository.Create(entity);
        }

        public bool Delete(string uid)
        {
            return this.portfolioRepository.Delete(uid);
        }

        public ICollection<Portfolio> GetAll()
        {
            return this.portfolioRepository.GetAll().ToList();
        }

        public Portfolio GetOne(string uid)
        {
            return this.portfolioRepository.GetOne(uid);
        }

        public bool Update(string uid, bool state)
        {
            return this.portfolioRepository.Update(uid, state);
        }

        public bool Update(string uid, string name)
        {
            return this.portfolioRepository.Update(uid, name);
        }

        public bool Update(string uid, Portfolio entity)
        {
            return this.portfolioRepository.Update(uid, entity);
        }
    }
}
