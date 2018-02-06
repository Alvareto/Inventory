using System;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory
{
    public class NHibernateUnitOfWork : IUnitOfWork
    {
        protected ISession _session;
        protected ITransaction _transaction;

        public NHibernateUnitOfWork()
            : this(NHibernateSessionProvider.SessionFactory.OpenSession())
        {
        }

        public NHibernateUnitOfWork(ISession session)
        {
            if (session == null)
                throw new ArgumentNullException("session");
            _session = session;
            BeginTransaction();
        }

        public ISession Session => _session;

        #region IUnitOfWork Members

        public virtual void Save()
        {
            if (_session == null)
                throw new InvalidOperationException("Session has not been initialized.");
            if (_transaction == null || !_transaction.IsActive)
                throw new InvalidOperationException("No transaction is active.");
            _transaction.Commit();
        }

        #endregion

        protected virtual void BeginTransaction()
        {
            if (_session == null)
                throw new InvalidOperationException("Session has not been initialized.");
            _transaction = _session.BeginTransaction();
        }

        private void CloseTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        private void CloseSession()
        {
            if (_session != null)
            {
                _session.Close();
                _session.Dispose();
                _session = null;
            }
        }

        #region IDisposable Methods

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                {
                    CloseTransaction();
                    CloseSession();
                }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}