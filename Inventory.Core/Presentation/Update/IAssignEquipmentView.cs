using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IAssignEquipmentView
    {
        Equipment SelectedEquipment { get; }
        User SelectedUser { get; }
        DateTime DateFrom { get; }
        bool Display(List<Equipment> assets, List<User> users);
    }
}