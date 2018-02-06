using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IDisposeEquipmentView
    {
        Equipment SelectedEquipment { get; }
        DateTime DateDisposed { get; }
        bool Display(List<Equipment> assets);
    }
}