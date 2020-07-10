using System;
using System.Collections.Generic;
using System.Linq;
using Star.Expense.Domain.Entities;
using Star.Expense.Domain.Interfaces;

namespace Star.Expense.Domain.Services
{
    public class TagService : ITagService
    {
        private readonly ICollection<Tag> _tempRepo = new List<Tag>();
        
        public void CreateTag(Tag tag)
        {
            if (!_tempRepo.Any(x => x.Name == tag.Name))
            {
                _tempRepo.Add(tag);
            }
            else
            {
                throw new Exception("Item already exists.");
            }
        }

        public IEnumerable<Tag> GetTags()
        {
            return _tempRepo;
        }
    }
}