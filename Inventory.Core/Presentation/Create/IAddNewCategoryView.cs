using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IAddNewCategoryView
    {
        bool Display(List<Category> categories);

        string CategoryName { get; }
        Category ParentCategory { get; }
    }
}