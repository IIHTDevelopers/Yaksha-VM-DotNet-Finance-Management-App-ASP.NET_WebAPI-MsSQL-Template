using FinanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FinanceManagementApp.DAL.Services.Repository
{
    public class FinanceRepository : IFinanceRepository
    {
        private readonly DatabaseContext _dbContext;
        public FinanceRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Transaction> AddTransactions(Transaction transaction)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteTransactionById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Transaction> GetFinance()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Transaction> GetTransactionById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Transaction> UpdateFinance(Transaction model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}