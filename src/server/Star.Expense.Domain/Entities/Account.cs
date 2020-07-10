using System.Collections.Generic;
using System.Transactions;
using Star.Expense.Domain.Enums;

namespace Star.Expense.Domain.Entities
{
    public class Account
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}