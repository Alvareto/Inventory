using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IAddNewCategoryView
    {
        string CategoryName { get; }
        Category ParentCategory { get; }
        bool Display(List<Category> categories);
    }
}