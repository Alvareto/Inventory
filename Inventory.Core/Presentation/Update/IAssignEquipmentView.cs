using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IAssignEquipmentView
    {
        bool Display(List<Equipment> assets, List<User> users);

        Equipment SelectedEquipment { get; }
        User SelectedUser { get; }
        DateTime DateFrom { get; }
    }
}