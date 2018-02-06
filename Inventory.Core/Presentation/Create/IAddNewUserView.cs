using System;

namespace Inventory.Core
{
    public interface IAddNewUserView
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime DateHired { get; }
        bool Display();
    }
}