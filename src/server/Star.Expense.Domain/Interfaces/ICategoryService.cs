using System.Collections.Generic;
using Star.Expense.Domain.Entities;

namespace Star.Expense.Domain.Interfaces
{
    public interface ICategoryService
    {
        void CreateCategory(Category category);
        IEnumerable<Category> GetCategories();
        
    }
}