using FinanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementApp.DAL.Services.Repository
{
    public interface IFinanceRepository
    {
        List<Transaction> GetFinance();
        Task<Transaction> AddTransactions(Transaction transaction);
        Task<Transaction> GetTransactionById(long id);
        Task<bool> DeleteTransactionById(long id);
        Task<Transaction> UpdateFinance(Transaction model);
    }
}

