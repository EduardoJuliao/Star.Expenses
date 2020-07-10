using System.Collections.Generic;
using Star.Expense.Domain.Entities;

namespace Star.Expense.Domain.Interfaces
{
    public interface ITagService
    {
        void CreateTag(Tag tag);
        IEnumerable<Tag> GetTags();
    }
}