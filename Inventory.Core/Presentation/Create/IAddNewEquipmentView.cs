using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IAddNewEquipmentView
    {
        bool Display(List<Category> categories);

        string EquipmentName { get; }
        Category EquipmentCategory { get; }
        DateTime DateAcquired { get; }
    }
}