using System.Collections.Generic;

namespace Inventory
{
    public partial interface IEquipmentRepository : IRepository<Equipment>
    {
        ICollection<Equipment> GetAll();
        ICollection<Equipment> GetAllUnassigned();
        ICollection<Equipment> GetAllAssigned();
        Equipment GetByKey(int _Id);
        Dictionary<Equipment, User> MapInventory();
    }
}
