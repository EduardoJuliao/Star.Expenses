using System;
using System.Collections.Generic;
using Star.Expense.Domain.Enums;

namespace Star.Expense.Domain.Entities
{
    public class Transacation
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public TransactionType TransactionType { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}