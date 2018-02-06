using System;

namespace Inventory
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}