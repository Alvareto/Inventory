using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IDisposeEquipmentView
    {
        bool Display(List<Equipment> assets);

        Equipment SelectedEquipment { get; }
        DateTime DateDisposed { get; }
    }
}