using System;

namespace Inventory
{
    public partial interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
