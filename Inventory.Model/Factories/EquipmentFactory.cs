using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class EquipmentFactory
    {
        public static Equipment CreateEquipment(string name, Category category, DateTime dateAcquired)
        {
            return new Equipment()
            {
                Name = name,
                Active = true,
                Category = category,
                DateAcquired = dateAcquired
            };
        }
    }
}
