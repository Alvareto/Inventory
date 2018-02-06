using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IAddNewEquipmentView
    {
        string EquipmentName { get; }
        Category EquipmentCategory { get; }
        DateTime DateAcquired { get; }
        bool Display(List<Category> categories);
    }
}