using System;

namespace Inventory.Model
{
    public class InventoryFactory
    {
        public static Inventory CreateInventory(Equipment equipment, User user, DateTime dateFrom)
        {
            return new Inventory
            {
                Equipments = equipment,
                Users = user,
                DateFrom = dateFrom,
                DateTo = null
            };
        }
    }
}