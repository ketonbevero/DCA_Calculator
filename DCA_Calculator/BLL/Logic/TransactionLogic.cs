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
    public class TransactionLogic : ITransactionLogic
    {
        private ITransactionRepository transacationRepository;

        public TransactionLogic(ITransactionRepository transactionRepository)
        {
            this.transacationRepository = transactionRepository;
        }

        public void Create(Transaction entity)
        {
            this.transacationRepository.Create(entity);
        }

        public bool Delete(string uid)
        {
            return this.transacationRepository.Delete(uid);
        }

        public bool DeleteSelectedBagTransactions(string bagId)
        {
            var bagTransactions = this.GetAll().Where(x => x.BagId == bagId);

            if (bagTransactions != null)
            {
                foreach (var transaction in bagTransactions)
                {
                    this.Delete(transaction.TransactionId);
                }

                return true;
            }
            else if (bagTransactions == null)
            {
                return true;
            }

            return false;
        }

        public ICollection<Transaction> GetAll()
        {
            return this.transacationRepository.GetAll().ToList();
        }

        public Transaction GetOne(string uid)
        {
            return this.GetOne(uid);
        }

        public bool Update(string uid, Transaction entity)
        {
            return this.transacationRepository.Update(uid, entity);
        }
    }
}
