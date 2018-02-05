using System.Collections.Generic;

namespace Inventory
{
    public partial interface ICategoryRepository : IRepository<Category>
    {
        ICollection<Category> GetAll();
        Category GetByKey(int _Id);
    }
}
