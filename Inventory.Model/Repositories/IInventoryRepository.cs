using System.Collections.Generic;

namespace Inventory
{
    public interface IInventoryRepository : IRepository<Inventory>
    {
        Inventory GetLatest(Equipment equipment);
        Inventory GetLatest(User user);
        ICollection<Inventory> GetAll();
    }
}