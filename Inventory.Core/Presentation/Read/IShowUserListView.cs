using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IShowUserListView
    {
        void Display(IMainFormController mainController, List<User> list);
    }
}