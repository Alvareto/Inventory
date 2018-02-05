using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface ITransferEquipmentView
    {
        bool Display(List<Equipment> assets, List<User> users);

        Equipment SelectedTransferEquipment { get; }
        User UserFrom { get; }
        User SelectedUserTo { get; }

        DateTime Date_ExTo_NewFrom { get; }
    }
}