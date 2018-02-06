using System;
using System.Collections.Generic;

namespace Inventory.Core
{
    public interface IDeactivateUserView
    {
        User SelectedUser { get; }
        DateTime DateFired { get; }
        bool Display(List<User> users);
    }
}