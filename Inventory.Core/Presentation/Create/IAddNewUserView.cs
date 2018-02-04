using System;

namespace Inventory.Core
{
    public interface IAddNewUserView
    {
        bool Display();

        string FirstName { get; }
        string LastName { get; }
        DateTime DateHired { get; }
    }
}