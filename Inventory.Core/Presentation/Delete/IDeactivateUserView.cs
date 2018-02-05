using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IDeactivateUserView
    {
        bool Display(List<User> users);

        User SelectedUser { get; }
        DateTime DateFired { get; }
    }
}