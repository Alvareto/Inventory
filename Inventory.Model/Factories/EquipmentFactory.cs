using System;

namespace Inventory.Model
{
    public class EquipmentFactory
    {
        public static Equipment CreateEquipment(string name, Category category, DateTime dateAcquired)
        {
            var equipment = new Equipment
            {
                Name = name,
                Active = true,
                Category = category,
                DateAcquired = dateAcquired,
                DateDisposed = null
            };

            //equipment.Users.Add(InventoryFactory.CreateInventory(equipment, UserFactory.CreateDefaultUser(), dateAcquired));

            return equipment;
        }
    }
}