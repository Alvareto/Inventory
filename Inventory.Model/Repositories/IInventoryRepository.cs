using System;
using System.Collections.Generic;

namespace Inventory
{
    public partial interface IInventoryRepository : IRepository<Inventory>
    {
        Inventory GetLatest(Equipment equipment);
        Inventory GetLatest(User user);
        ICollection<Inventory> GetAll();
    }
}
