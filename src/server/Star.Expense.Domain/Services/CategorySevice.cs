using System;
using System.Collections.Generic;
using System.Linq;
using Star.Expense.Domain.Entities;
using Star.Expense.Domain.Interfaces;

namespace Star.Expense.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICollection<Category> _tempRepo = new List<Category>();
        
        public void CreateCategory(Category category)
        {
            if (!_tempRepo.Any(x => x.Name == category.Name))
            {
                _tempRepo.Add(category);
            }
            else
            {
                throw new Exception("Item already exists.");
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return _tempRepo;
        }
    }
}