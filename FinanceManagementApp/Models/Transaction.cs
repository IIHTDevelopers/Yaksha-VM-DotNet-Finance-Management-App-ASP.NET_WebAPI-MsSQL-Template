using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceManagementApp.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public int UserID { get; set; }
    }
}