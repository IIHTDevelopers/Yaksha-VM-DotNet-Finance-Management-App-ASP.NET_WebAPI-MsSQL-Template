
using FinanceManagementApp.Models;
using System.Data.Entity;


namespace FinanceManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}