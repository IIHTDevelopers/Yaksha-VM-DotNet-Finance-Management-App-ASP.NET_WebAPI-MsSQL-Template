using FinanceManagementApp.DAL.Interrfaces;
using FinanceManagementApp.DAL.Services.Repository;
using FinanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FinanceManagementApp.DAL.Services
{
    public class FinanceService : IFinanceService
    {
        private readonly IFinanceRepository _repository;

        public FinanceService(IFinanceRepository repository)
        {
            _repository = repository;
        }

        public Task<Transaction> AddTransactions(Transaction transaction)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTransactionById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Transaction> GetFinance()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Transaction> GetTransactionById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Transaction> UpdateFinance(Transaction model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}