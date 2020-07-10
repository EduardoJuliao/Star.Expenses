using System.Collections.Generic;

namespace Star.Expense.Domain.Entities
{
    public class Category
    {
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}