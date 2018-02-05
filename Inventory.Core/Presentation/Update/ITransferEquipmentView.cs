using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface ITransferEquipmentView
    {
        bool Display(List<Equipment> assets, List<User> users, Dictionary<Equipment, User> currentEquipmentUser);

        Equipment SelectedTransferEquipment { get; }
        User UserFrom { get; }
        User SelectedUserTo { get; }

        DateTime Date_ExTo_NewFrom { get; }
    }
}