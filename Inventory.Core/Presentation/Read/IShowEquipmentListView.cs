using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IShowEquipmentListView
    {
        void Display(IMainFormController mainController, List<Equipment> list);
    }
}